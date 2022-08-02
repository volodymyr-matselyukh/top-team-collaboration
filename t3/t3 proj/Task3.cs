namespace t3_proj
{
    public class Task3
    {
        public int Task3Function(int[] array, int expectedAverage)
        {
            int result = 0;

            for (int i = 1; i <= array.Length; i++)
            {
                for (int j = 0; j <= array.Length - i; j++)
                {
                    var average = Average(array, j, i);
                    if (average == expectedAverage) result++;

                    if (result > 1000000000) return 1000000000;
                }
            }

            return result;
        }

        private double Average(int[] array, int skip, int take)
        {
            return array.Skip(skip).Take(take).Sum() / (double)take;
        }
    }
}
