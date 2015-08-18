using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;
using jvm4csharp.java.util;
using NUnit.Framework;

namespace jvm4csharp.Tests.java.util
{
    [TestFixture]
    public class ArraysTests : IntegrationTestBase
    {
        [Test]
        public void Method_asList()
        {
            var stringArray = new ObjectArray<String>(3);
            stringArray[0] = "string 1";
            stringArray[1] = "string 2";
            stringArray[2] = "string 3";

            List<String> list = Arrays.asList(stringArray);
            AssertEx.IsValidJavaObject(list);
        }
    }
}
