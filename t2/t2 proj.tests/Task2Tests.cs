using NUnit.Framework;

namespace t2_proj.tests
{
    public class Task2Tests
    {
        [TestCase(new int[] { 2,1,1,3,2,1,1,3} , 3)]
        [TestCase(new int[] { 7,5,2,7,2,7,4,7}, 6)]
        [TestCase(new int[] { 7, 1, 1, 7, 1, 1, 1, 1,  7 }, 2)]
        [TestCase(new int[] { 7, 3,7,3,1,3,4,1 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 1)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 2, 2 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1,2,3,1,2,3,4,3,1,1,2,3,4,1 }, 4)]

        public void Check(int[] A, int result)
        {
            var actualResult = new Task2().Solution(A);

            Assert.AreEqual(result, actualResult);
        }
    }
}
