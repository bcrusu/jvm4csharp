using System.Diagnostics;
using jvm4csharp.java.lang;
using NUnit.Framework;
using System = jvm4csharp.java.lang.System;

namespace jvm4csharp.Tests
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        public static JvmManager JvmManager { get; set; }

        [SetUp]
        public void SetUp()
        {
            var options = new JvmManagerOptions();
            options.JavaHome = Configuration.JavaHome;
            options.JvmHooks.SetExitHook(ExitHook);
            options.JvmHooks.SetAbortHook(AbortHook);

            JvmManager = JvmManager.Create(options);
        }

        [TearDown]
        public void TearDown()
        {
            JvmManager?.Dispose();
        }

        private static void ExitHook(int code)
        {
            Debug.WriteLine($"JVM exited with code '{code}'.");
        }

        private static void AbortHook()
        {
            Debug.WriteLine("JVM aborted.");
        }
    }
}
