using NUnit.Framework;

namespace jvm4csharp.Tests
{
    public abstract class IntegrationTestBase
    {
        protected JvmSession Session;

        [TestFixtureSetUp]
        public void TestSetUp()
        {
            Session = JvmManager.Current.OpenSession(true);
        }

        [TestFixtureTearDown]
        public void TestTearDown()
        {
            if (Session != null)
                Session.Dispose();
        }
    }
}
