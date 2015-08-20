using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using jvm4csharp.java.lang;

namespace jvm4csharp.JniApiWrappers
{
    internal sealed class ProxyRegistry
    {
        public static ProxyRegistry Current { get; private set; }

        private readonly IDictionary<string, Type> _classNameToProxyType = new Dictionary<string, Type>();
        private readonly IDictionary<Type, string> _proxyTypeToClassNameMap = new Dictionary<Type, string>();

        private ProxyRegistry(IEnumerable<Type> proxyTypes)
        {
            Debug.Assert(proxyTypes != null);

            var defaultProxyTypes = GetDefaultProxyTypes();
            foreach (var item in defaultProxyTypes)
                RegisterProxy(item.Item1, item.Item2);

            foreach (var type in proxyTypes)
                RegisterProxy(type, null);
        }

        public static void Configure(IEnumerable<Type> proxyTypes)
        {
            Current = new ProxyRegistry(proxyTypes);
        }

        //TODO: handle arrays
        public string GetClassName(Type javaProxyType)
        {
            Debug.Assert(javaProxyType != null);

            if (javaProxyType.IsGenericType)
                javaProxyType = javaProxyType.GetGenericTypeDefinition();

            string className;
            if (!_proxyTypeToClassNameMap.TryGetValue(javaProxyType, out className))
                throw new ArgumentException($"Proxy type '{javaProxyType}' not recognized.");

            return className;
        }

        public bool TryGetProxyType(string internalClassName, out Type proxyType)
        {
            Debug.Assert(internalClassName != null);
            return _classNameToProxyType.TryGetValue(internalClassName, out proxyType);
        }

        private void RegisterProxy(Type proxyType, JavaProxyAttribute javaProxyAttribute)
        {
            Debug.Assert(proxyType != null);

            if (javaProxyAttribute == null)
            {
                javaProxyAttribute = WrapperHelpers.GetJavaProxyAttribute(proxyType);
                if (javaProxyAttribute == null)
                    throw new InvalidJavaProxyException(proxyType, "Could not find 'JavaProxyAttribute'.");
            }

            var internalClassName = javaProxyAttribute.ClassName;
            if (_classNameToProxyType.ContainsKey(internalClassName))
                throw new InvalidJavaProxyException(proxyType, $"Found duplicate proxy for Java class '{internalClassName}'.");

            if (string.IsNullOrWhiteSpace(internalClassName))
                throw new InvalidJavaProxyException(proxyType, "Missing 'JavaProxyAttribute.ClassName' property.");

            if (!typeof(IJavaObject).IsAssignableFrom(proxyType))
                throw new InvalidJavaProxyException(proxyType, "Proxy types must implement 'IJavaObject'.");

            if (!proxyType.IsInterface)
            {
                if (!typeof(java.lang.Object).IsAssignableFrom(proxyType) && !typeof(Throwable).IsAssignableFrom(proxyType))
                    throw new InvalidJavaProxyException(proxyType, "Proxy types must inherit from 'java.lang.Object' or 'java.lang.Throwable'.");
            }

            ValidateGenericTypeParameters(proxyType);

            _classNameToProxyType[internalClassName] = proxyType;
            _proxyTypeToClassNameMap[proxyType] = internalClassName;
        }

        private static void ValidateGenericTypeParameters(Type proxyType)
        {
            if (!proxyType.IsGenericTypeDefinition)
                return;

            var genericTypeDefinition = proxyType.GetGenericTypeDefinition().GetTypeInfo();
            var genericTypeParameters = genericTypeDefinition.GenericTypeParameters;

            foreach (var typeParameter in genericTypeParameters)
            {
                var constraints = typeParameter.GetGenericParameterConstraints();
                if (!constraints.Any(constraint => (typeof(IJavaObject).IsAssignableFrom(constraint))))
                    throw new InvalidJavaProxyException(proxyType, $"Generic type parameter '{typeParameter.Name}' does not implement 'IJavaObject'.");
            }
        }

        private static IEnumerable<Tuple<Type, JavaProxyAttribute>> GetDefaultProxyTypes()
        {
            var assembly = typeof(ProxyRegistry).Assembly;
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                var attr = WrapperHelpers.GetJavaProxyAttribute(type);
                if (attr != null)
                    yield return new Tuple<Type, JavaProxyAttribute>(type, attr);
            }
        }
    }
}
