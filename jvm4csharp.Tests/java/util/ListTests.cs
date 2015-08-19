using jvm4csharp.java.lang;
using jvm4csharp.java.util;
using NUnit.Framework;

namespace jvm4csharp.Tests.java.util
{
    [TestFixture]
    public class ListTests : IntegrationTestBase
    {
        private const string ExpectedStringPrefix = "test string ";

        [Test]
        public void Method_size()
        {
            const int expectedSize = 4;
            var list = CreateTestList(expectedSize);
            var actualSize = list.size();

            Assert.AreEqual(expectedSize, actualSize);
        }

        [Test]
        public void Methods_get()
        {
            var expectedString = ExpectedStringPrefix + 2;

            var list = CreateTestList(5);
            var actualString = (string)list.get(2);

            Assert.AreEqual(expectedString, actualString);
        }


        [Test]
        public void Methods_add()
        {
            var expectedString = ExpectedStringPrefix + 2;

            var list = CreateTestList(3);
            list.add(expectedString);

            var actualString = (string)list.get(2);

            Assert.AreEqual(expectedString, actualString);
        }

        private static List<String> CreateTestList(int size)
        {
            var list = new LinkedList<String>();
            for (var i = 0; i < size; i++)
                list.addLast(ExpectedStringPrefix + i);

            return list;
        }
    }
}
