using NUnit.Framework;

namespace Problems.Tests
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
            Program x = new Program();
            string first = x.Prefix("hello");
            Assert.AreEqual(first, "5,1:hello");

            Program y = new Program();
            string second = x.Prefix("");
            Assert.AreEqual(second, "0,1:");

            Program z = new Program();
            string third = x.Prefix("what ... did you say??");
            Assert.AreEqual(third, "22,5:what ... did you say??");

        }
    }
}