using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using jvm4csharp.ArrayUtils;

namespace jvm4csharp.JniApiWrappers
{
    internal sealed class ProxyRegistry
    {
        public static ProxyRegistry Current { get; private set; } 

        private readonly IDictionary<string, Type> _classNameToConcreteProxyType = new Dictionary<string, Type>();
        private readonly IDictionary<Type, string> _proxyTypeMap = new Dictionary<Type, string>();

        private ProxyRegistry(IEnumerable<Type> proxyTypes)
        {
            if (proxyTypes == null) throw new ArgumentNullException(nameof(proxyTypes));

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
            if (javaProxyType == null) throw new ArgumentNullException(nameof(javaProxyType));

            if (javaProxyType.IsGenericTypeDefinition)
                throw new ArgumentException(""); //TODO

            if (javaProxyType.IsGenericType)
                javaProxyType = javaProxyType.GetGenericTypeDefinition();

            string className;
            if (!_proxyTypeMap.TryGetValue(javaProxyType, out className))
                throw new ArgumentException($"Proxy type '{javaProxyType}' not recognized.");

            return className;
        }

        public Type GetProxyType(string internalClassName)
        {
            Type result;
            _classNameToConcreteProxyType.TryGetValue(internalClassName, out result);
            return result;
        }

        private void RegisterProxies(IEnumerable<Type> types)
        {
            if (types == null) throw new ArgumentNullException(nameof(types));
            foreach (var type in types)
                RegisterProxy(type);
        }

        private void RegisterProxy(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            var attr = (JavaProxyAttribute)type.GetCustomAttributes(typeof(JavaProxyAttribute), false).FirstOrDefault();
            if (attr == null)
                throw new ArgumentException($"Invalid proxy definition '{type}'. Could not find 'JavaProxyAttribute'.");

            var className = attr.ClassName;
            if (_classNameToConcreteProxyType.ContainsKey(className))
                throw new ArgumentException($"Duplicate proxy type '{type}' detected. Java class name '{className}'.");

            var concreteProxyType = attr.ConcreteProxyType;
            var proxyType = type;

            if (string.IsNullOrWhiteSpace(className))
                throw new ArgumentException($"Invalid proxy definition '{type}'. Missing 'JavaProxyAttribute.ClassName' property.");

            if (type.IsAbstract || type.IsInterface)
            {
                if (concreteProxyType == null)
                    throw new ArgumentException($"Invalid proxy definition '{type}'. Abstract proxy types must specify the 'JavaProxyAttribute.ConcreteProxyType' property.");

                proxyType = concreteProxyType;
            }

            ValidateProxyType(type, proxyType);

            Debug.Assert(proxyType != null);

            _classNameToConcreteProxyType[className] = proxyType;
            _proxyTypeMap[type] = className;
        }

        private static void ValidateProxyType(Type baseType, Type proxyType)
        {
            if (!typeof(java.lang.Object).IsAssignableFrom(proxyType) && !typeof(java.lang.Throwable).IsAssignableFrom(proxyType))
                throw new ArgumentException($"Invalid proxy definition '{proxyType}'. Proxy types must inherit from 'java.lang.Object' or 'java.lang.Throwable'.");

            if (!ValidateGenericTypeParameters(baseType, out baseType))
                throw new ArgumentException(""); //TODO

            if (baseType != proxyType)
            {
                if (!ValidateGenericTypeParameters(proxyType, out proxyType))
                    throw new ArgumentException(""); //TODO

                if (!baseType.IsAssignableFrom(proxyType))
                {
                    var correctiveAction = baseType.IsInterface ? "implement" : "subclass";
                    throw new ArgumentException($"Invalid proxy definition '{baseType}'. Concrete proxy type '{proxyType}' must {correctiveAction} '{baseType}'.");
                }
            }
        }

        private static bool ValidateGenericTypeParameters(Type type, out Type concreteType)
        {
            concreteType = type;
            if (!type.IsGenericTypeDefinition)
                return true;

            var genericTypeDefinition = type.GetGenericTypeDefinition().GetTypeInfo();
            var genericTypeParameters = genericTypeDefinition.GenericTypeParameters;

            for (var i = 0; i < genericTypeParameters.Length; i++)
            {
                var typeParameter = genericTypeParameters[i];
                var constraints = typeParameter.GetGenericParameterConstraints();

                if (constraints.Length == 0)
                    throw new ArgumentException(""); //TODO

                foreach (var constraint in constraints)
                    if (!(typeof(IJavaObject).IsAssignableFrom(constraint)))
                        throw new ArgumentException(""); //TODO
            }

            var typeArguments = genericTypeParameters.Select(x => typeof(IJavaObject)).ToArray();
            concreteType = genericTypeDefinition.MakeGenericType(typeArguments);

            return true;
        }

        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
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

            yield return typeof (BooleanArray);
            yield return typeof (ByteArray);
            yield return typeof (CharArray);
            yield return typeof (DoubleArray);
            yield return typeof (FloatArray);
            yield return typeof (IntArray);
            yield return typeof (LongArray);
            yield return typeof (ShortArray);
        }
    }
}
