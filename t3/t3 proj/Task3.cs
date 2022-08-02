namespace t3_proj
{
    public class Task3
    {
        public int solution(int[] A, int S)
        {
            int result = 0;

            for (int i = 1; i <= A.Length; i++)
            {
                for (int j = 0; j <= A.Length - i; j++)
                {
                    var average = Average(A, j, i);
                    if (average == S) result++;

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
