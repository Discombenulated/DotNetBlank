using NUnit.Framework;
using DotNetBlank.Model;

namespace DotNetBlank.Tests.Model
{
    [TestFixture]
    public class SomeClassTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(10, SomeClass.Value);
        }
    }
}