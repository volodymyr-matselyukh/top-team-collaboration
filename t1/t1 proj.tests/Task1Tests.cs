using NUnit.Framework;
using t1_proj;

namespace task1
{
    public class Task1Tests
    {
        [TestCase(new string[] { "test1a", "test2", "test1b", "test1c", "test3" }, new string[] { "Wrong answer", "OK", "Runtime error", "OK", "Time limit exceeded" }, 33)]
        [TestCase(new string[] { "codility1", "codility3", "codility2", "codility4b", "codility4a" }, new string[] { "Wrong answer", "OK", "OK", "Runtime error", "OK" }, 50)]
        public void Check(string[] T, string[] R, int result)
        {
            var actualResult = new Task1().solution(T, R);

            Assert.AreEqual(result, actualResult);
        }
    }
}