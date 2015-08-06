using jvm4csharp.java.lang;
using NUnit.Framework;

namespace jvm4csharp.Tests.java.lang
{
    [TestFixture]
    public class StringTests : IntegrationTestBase
    {
        [Test]
        public void ImplicitCast()
        {
            const string clrString = "CLR String";
            String javaString = clrString;

            Assert.NotNull(javaString);
            AssertEx.IsValidJavaProxy(javaString);

            Assert.AreEqual(clrString.Length, javaString.length());

            string javaString2Clr = javaString;
            Assert.AreEqual(clrString, javaString2Clr);
        }
    }
}
