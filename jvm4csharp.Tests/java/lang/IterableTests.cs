using jvm4csharp.java.lang;
using jvm4csharp.java.util;
using NUnit.Framework;

namespace jvm4csharp.Tests.java.lang
{
    [TestFixture]
    public class IterableTests : IntegrationTestBase
    {
        [Test]
        public void EnumerableTest()
        {
            const string expectedStringBase = "str1ng";

            var list = new ArrayList<String>();
            list.add(expectedStringBase + "0");
            list.add(expectedStringBase + "1");
            list.add(expectedStringBase + "2");

            var currentIndex = -1;
            foreach (var item in list)
            {
                currentIndex++;
                Assert.AreEqual(expectedStringBase + currentIndex, (string)item);
            }

            Assert.AreEqual(2, currentIndex);
        }
    }
}
