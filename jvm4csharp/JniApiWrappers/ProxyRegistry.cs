using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal sealed class ProxyRegistry
    {
        public static ProxyRegistry Current { get; private set; }

        private readonly IDictionary<string, Type> _classNameToProxyTypeMap = new Dictionary<string, Type>();
        private readonly IDictionary<string, Type> _classNameToGenericProxyTypeMap = new Dictionary<string, Type>();
        private readonly IDictionary<Type, string> _proxyTypeToClassNameMap = new Dictionary<Type, string>();

        private ProxyRegistry(IEnumerable<Type> proxyTypes)
        {
            Debug.Assert(proxyTypes != null);

            var defaultProxyTypes = GetDefaultProxyTypes();
            RegisterProxies(defaultProxyTypes);

            RegisterProxies(proxyTypes);
        }

        public static void Configure(IEnumerable<Type> proxyTypes)
        {
            Current = new ProxyRegistry(proxyTypes);
        }

        //TODO: handle arrays
        public string GetClassName(Type javaProxyType)
        {
            Debug.Assert(javaProxyType != null);

            if (javaProxyType.IsGenericTypeDefinition)
                throw new ArgumentException(""); //TODO

            if (javaProxyType.IsGenericType)
                javaProxyType = javaProxyType.GetGenericTypeDefinition();

            string className;
            if (!_proxyTypeToClassNameMap.TryGetValue(javaProxyType, out className))
                throw new ArgumentException($"Proxy type '{javaProxyType}' not recognized.");

            return className;
        }

        public bool TryGetProxyType(string internalClassName, bool isGenericProxy, out Type proxyType)
        {
            Debug.Assert(internalClassName != null);

            var map = _classNameToProxyTypeMap;
            if (isGenericProxy)
                map = _classNameToGenericProxyTypeMap;

            return map.TryGetValue(internalClassName, out proxyType);
        }

        private void RegisterProxies(IEnumerable<Type> types)
        {
            foreach (var type in types)
                RegisterProxy(type);
        }

        private void RegisterProxy(Type proxyType)
        {
            Debug.Assert(proxyType != null);

            var attr = (JavaProxyAttribute)proxyType.GetCustomAttributes(typeof(JavaProxyAttribute), false).FirstOrDefault();
            if (attr == null)
                throw new ArgumentException($"Invalid proxy definition '{proxyType}'. Could not find 'JavaProxyAttribute'.");

            var destinationProxyMap = _classNameToProxyTypeMap;
            if (proxyType.IsGenericTypeDefinition)
                destinationProxyMap = _classNameToGenericProxyTypeMap;

            var internalClassName = attr.ClassName;
            if (destinationProxyMap.ContainsKey(internalClassName))
                throw new ArgumentException($"Duplicate proxy type '{proxyType}' detected. Java class name '{internalClassName}'.");

            if (string.IsNullOrWhiteSpace(internalClassName))
                throw new ArgumentException($"Invalid proxy definition '{proxyType}'. Missing 'JavaProxyAttribute.ClassName' property.");

            if (!proxyType.IsInterface)
            {
                if (!typeof(java.lang.Object).IsAssignableFrom(proxyType) && !typeof(Throwable).IsAssignableFrom(proxyType))
                    throw new ArgumentException($"Invalid proxy definition '{proxyType}'. Proxy types must inherit from 'java.lang.Object' or 'java.lang.Throwable'.");
            }

            ValidateGenericTypeParameters(proxyType);

            destinationProxyMap[internalClassName] = proxyType;
            _proxyTypeToClassNameMap[proxyType] = internalClassName;
        }

        private static void ValidateGenericTypeParameters(Type type)
        {
            if (!type.IsGenericTypeDefinition)
                return;

            var genericTypeDefinition = type.GetGenericTypeDefinition().GetTypeInfo();
            var genericTypeParameters = genericTypeDefinition.GenericTypeParameters;

            foreach (var typeParameter in genericTypeParameters)
            {
                var constraints = typeParameter.GetGenericParameterConstraints();

                if (constraints.Length == 0)
                    throw new ArgumentException(""); //TODO

                foreach (var constraint in constraints)
                    if (!(typeof(IJavaObject).IsAssignableFrom(constraint)))
                        throw new ArgumentException(""); //TODO
            }
        }

        private static IEnumerable<Type> GetDefaultProxyTypes()
        {
            var javaLangNamespace = "jvm4csharp.java.";

            var assembly = typeof(ProxyFactory).Assembly;
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var include = type.FullName.StartsWith(javaLangNamespace, StringComparison.InvariantCultureIgnoreCase);
                if (include)
                    yield return type;
            }

            yield return typeof(BooleanArray);
            yield return typeof(ByteArray);
            yield return typeof(CharArray);
            yield return typeof(DoubleArray);
            yield return typeof(FloatArray);
            yield return typeof(IntArray);
            yield return typeof(LongArray);
            yield return typeof(ShortArray);
        }
    }
}
