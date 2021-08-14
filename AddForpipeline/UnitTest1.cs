using NUnit.Framework;

namespace AddForpipeline
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            AddClass a = new AddClass();
            Assert.AreEqual(a.Add(5, 10),15);
        }
    }
}