using NUnit.Framework;

namespace jvm4csharp.Tests.Session
{
    [TestFixture]
    public class JvmSessionTests : IntegrationTestBase
    {
        [Test]
        public void Attached_Successfully()
        {
            Assert.NotNull(Session);
            Assert.IsTrue(Session.IsAttached);
        }
    }
}
