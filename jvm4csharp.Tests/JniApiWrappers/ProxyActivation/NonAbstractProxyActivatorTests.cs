using System;
using jvm4csharp.ArrayUtils;
using jvm4csharp.java.util;
using jvm4csharp.JniApiWrappers.ProxyActivation;
using NUnit.Framework;
using String = jvm4csharp.java.lang.String;

namespace jvm4csharp.Tests.JniApiWrappers.ProxyActivation
{
    [TestFixture]
    public class NonAbstractProxyActivatorTests
    {
        [Test]
        public void CreateInstance_returns_correct_instance()
        {
            var proxyType = typeof (String);
            var instance = NonAbstractProxyActivator.Instance.CreateInstance(proxyType);

            Assert.NotNull(instance);
            Assert.IsInstanceOf<String>(instance);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInstance_fails_for_abstract_type()
        {
            var proxyType = typeof(ArrayBase<int>);
            NonAbstractProxyActivator.Instance.CreateInstance(proxyType);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInstance_fails_for_generic_type_definition()
        {
            var proxyType = typeof(Iterator<>);
            NonAbstractProxyActivator.Instance.CreateInstance(proxyType);
        }
    }
}
