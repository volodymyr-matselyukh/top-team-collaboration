using NUnit.Framework;
using t1_proj;

namespace task1
{
    public class Task1Tests
    {
        [TestCase("300.01", new string[] { "300.00", "200.00", "100.00" }, "t1")]
        [TestCase("1.00", new string[] { "0.05", "1.00" }, "t1")]
        [TestCase("300.01", new string[] { "30.00", "300.00", "200.00", "100.00" }, "t1")]
        public void Check(string excess, string[] input, string result)
        {
            var actualResult = new Task1().Task1Function(excess, input);

            Assert.AreEqual(result, actualResult);
        }
    }
}
