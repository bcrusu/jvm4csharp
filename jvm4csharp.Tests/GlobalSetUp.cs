using NUnit.Framework;

namespace jvm4csharp.Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        [SetUp]
        public void RunBeforeAnyTests()
        {
            var options = new JvmManagerOptions();
            options.CreateJvmAtStartup = false;
            options.MinThreadPoolSize = 8;
            options.JavaHome = @"C:\Program Files\Java\jre1.8.0_51";

            JvmManager.Configure(options);
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
        }
    }
}
