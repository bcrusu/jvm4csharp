using jvm4csharp.ArrayUtils;
using jvm4csharp.java.lang;
using NUnit.Framework;

namespace jvm4csharp.Tests.ArrayUtils
{
    [TestFixture]
    public class ObjectArrayTests : IntegrationTestBase
    {
        [Test]
        public void ActivatonTest()
        {
            var stringArray = new ObjectArray<String>(0);
            AssertEx.IsValidJavaObject(stringArray);
        }

        [Test]
        public void LengthTest()
        {
            const int length = 3;
            var stringArray = new ObjectArray<String>(length);

            Assert.AreEqual(length, stringArray.Length);
        }

        [Test]
        public void IndexedPropertyTest()
        {
            const string expectedString1 = "string 1";
            const string expectedString2 = "2 string";

            var stringArray = new ObjectArray<String>(2);
            stringArray[0] = expectedString1;
            stringArray[1] = expectedString2;

            var actualString1 = (string)stringArray[0];
            var actualString2 = (string)stringArray[1];

            Assert.AreEqual(expectedString1, actualString1);
            Assert.AreEqual(expectedString2, actualString2);
        }

        [Test]
        public void EnumerableTest()
        {
            const string expectedStringBase = "s7r";
            const int length = 5;

            var stringArray = new ObjectArray<String>(length);
            for (int i = 0; i < length; i++)
                stringArray[i] = expectedStringBase + i;

            var currentIndex = 0;
            foreach (var actualString in stringArray)
            {
                var actualClrString = (string) actualString;
                Assert.AreEqual(expectedStringBase + currentIndex, actualClrString);
                currentIndex++;
            }

            Assert.AreEqual(length, currentIndex);
        }
    }
}
