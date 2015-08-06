using System;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;
using jvm4csharp.JniApiWrappers.ProxyActivation;
using NUnit.Framework;

namespace jvm4csharp.Tests.JniApiWrappers.ProxyActivation
{
    [TestFixture]
    public class RemotingProxyActivatorTests
    {
        [Test]
        public void CreateInstance_returns_correct_instance()
        {
            var proxyType = typeof (Iterator<Class>);
            var instance = RemotingProxyActivator.Instance.CreateInstance(proxyType);

            Assert.NotNull(instance);
            Assert.IsInstanceOf(proxyType, instance);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInstance_fails_for_non_abstract_type()
        {
            var proxyType = typeof(Class);
            RemotingProxyActivator.Instance.CreateInstance(proxyType);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateInstance_fails_for_generic_type_definition()
        {
            var proxyType = typeof(Iterator<>);
            RemotingProxyActivator.Instance.CreateInstance(proxyType);
        }
    }
}
