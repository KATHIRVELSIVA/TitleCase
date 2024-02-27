using NUnit.Framework.Internal;
using TitleCase.Pages;

namespace TitleCase.tests
{
    public class Tests
    {
        TestMe testMe = new TestMe();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CheckCorrectValue()
        {
            string output = testMe.makeTitle("hello world");
            string expected = "Hello World";
            Assert.That(output, Is.EqualTo(expected));
        }
        [Test]
        public void CheckWrongValue()
        {
            string output = testMe.makeTitle("hello world");
            string expected = "Hello WORLD";
            Assert.That(output, Is.Not.EqualTo(expected));
        }
    }
}