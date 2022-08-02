namespace t2_proj
{
    public class Task2
    {
        public int Solution(int[] A)
        {

            if (A.Length == 1) 
            {
                return A.Length;
            };

            int result = A.Length;

            bool proceedIteration = true;

            int initialIndex = 0;
            while (proceedIteration) 
            {
                int length = 0;
                List<int> uniqueDigits = A.Distinct().ToList();
                for (int i= initialIndex; i < A.Length; i++)
                {
                    if (uniqueDigits.Count() > 0)
                    {
                        length++;
                        if (uniqueDigits.Contains(A[i]))
                        {
                            uniqueDigits.Remove(A[i]);
                        }
                    }
                    else 
                    {
                        break;
                    }
                }
                initialIndex++;
                if ((initialIndex +1+ uniqueDigits.Count() >= A.Length) || length == uniqueDigits.Count())
                {
                    proceedIteration = false;
                 }

                if (length < result && uniqueDigits.Count() == 0) 
                {
                    result = length;
                }

            }

            return  result;
        }
    }
}
