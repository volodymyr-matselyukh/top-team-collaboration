using NUnit.Framework;
using System.Linq;

namespace t3_proj.tests
{
    public class Task3Tests
    {
        [TestCase(new int[] { 2, 1, 3 }, 2, 3)]
        [TestCase(new int[] { 0, 4, 3, -1 }, 2, 2)]
        [TestCase(new int[] { 2, 1, 4 }, 3, 0)]
        [TestCase(new int[] { 3, 3, 3 }, 3, 6)]
        [TestCase(new int[] { 3, -3, 3 }, 0, 2)]
        public void Check(int[] array, int average, int result)
        {
            var actualResult = new Task3().solution(array, average);

            Assert.AreEqual(result, actualResult);
        }
    }
}
