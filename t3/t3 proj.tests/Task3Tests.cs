using NUnit.Framework;

namespace t3_proj.tests
{
    public class Task3Tests
    {
        [TestCase("300.01", new string[] { "300.00", "200.00", "100.00" }, "t3")]
        [TestCase("1.00", new string[] { "0.05", "1.00" }, "t3")]
        [TestCase("300.01", new string[] { "30.00", "300.00", "200.00", "100.00" }, "t3")]
        public void Check(string excess, string[] input, string result)
        {
            var actualResult = new Task3().Task3Function(excess, input);

            Assert.AreEqual(result, actualResult);
        }
    }
}
