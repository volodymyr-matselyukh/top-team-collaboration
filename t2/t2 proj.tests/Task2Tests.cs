using NUnit.Framework;

namespace t2_proj.tests
{
    public class Task2Tests
    {
        [TestCase("300.01", new string[] { "300.00", "200.00", "100.00" }, "t2")]
        [TestCase("1.00", new string[] { "0.05", "1.00" }, "t2")]
        [TestCase("300.01", new string[] { "30.00", "300.00", "200.00", "100.00" }, "t2")]
        public void Check(string excess, string[] input, string result)
        {
            var actualResult = new Task2().Task2Function(excess, input);

            Assert.AreEqual(result, actualResult);
        }
    }
}
