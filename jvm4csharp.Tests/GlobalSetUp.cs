using NUnit.Framework;

namespace jvm4csharp.Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static JvmManager JvmManager { get; set; }

        [SetUp]
        public void RunBeforeAnyTests()
        {
            var options = new JvmManagerOptions();
            options.JavaHome = Configuration.JavaHome;

            JvmManager = JvmManager.Create(options);
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            if (JvmManager != null)
                JvmManager.DestroyJavaVm();
        }
    }
}
