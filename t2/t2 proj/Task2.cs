namespace t2_proj
{
    public class Task2
    {
        public int Solution(int[] A)
        {
            var distinctNumbers = A.Distinct().ToList();
            var distinctNumbersCount = distinctNumbers.Count();

            var startIndex = 0;
            var endIndex = 0;
            var shortestPath = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                startIndex = i;
                var neededNumbers = new List<int>(distinctNumbers);
                for (int j = i; j < A.Length; j++)
                {
                    if (neededNumbers.Count == 0)
                    {
                        break;
                    }

                    var foundIndex = neededNumbers.IndexOf(A[j]);
                    if (foundIndex > -1)
                    { 
                        neededNumbers.RemoveAt(foundIndex);
                        endIndex = j;
                    }
                }

                if (neededNumbers.Count == 0)
                {
                    if (endIndex - startIndex < shortestPath)
                    {
                        shortestPath = endIndex - startIndex + 1;
                    }

                    if (shortestPath == distinctNumbersCount)
                    {
                        break;
                    }
                }
            }

            return shortestPath;
        }
        //public int Solution(int[] A)
        //{

        //    if (A.Length == 1 || A.Length == 0) 
        //    {
        //        return A.Length;
        //    };

        //    int result = A.Length;
        //    bool proceedIteration = true;

        //    int initialIndex = 0;



        //    while (proceedIteration) 
        //    {
        //        int length = 0;

        //        List<int> uniqueDigits = A.Distinct().ToList();

        //        for (int i= initialIndex; i < A.Length; i++)
        //        {
        //            if (uniqueDigits.Count() > 0)
        //            {
        //                length++;
        //                if (uniqueDigits.Contains(A[i]))
        //                {
        //                    uniqueDigits.Remove(A[i]);
        //                }
        //            }
        //            else 
        //            {
        //                break;
        //            }
        //        }
        //        initialIndex++;

        //        if ((initialIndex + uniqueDigits.Count() >= A.Length) || length == uniqueDigits.Count())
        //        {
        //            proceedIteration = false;
        //         }

        //        if (length < result && uniqueDigits.Count() == 0) 
        //        {
        //            result = length;
        //        }

        //    }

        //    return  result;
        //}
    }
}
