using System.Text.RegularExpressions;

namespace t1_proj
{
    public class Task1
    {
        const string Ok = "OK";
        public int solution(string[] T, string[] R)
        {
            var taskLineList = new List<TaskLine>();

            for (int i = 0; i < T.Length; i++)
            {
                taskLineList.Add(new TaskLine
                {
                    TaskName = T[i],
                    Result = R[i]
                });
            }

            var taskName = "";
            var intIndex = 0;
            var groupsCount = 0;
            HashSet<string> groupSet = new HashSet<string>();

            for (int i = 0; i < T[0].Length; i++)
            {
                var firstTaskName = T[0];
                var test = 0;
                if (int.TryParse(firstTaskName.ElementAt(i).ToString(), out test))
                {
                    intIndex = i;
                    break;
                }
            }

            taskName = T[0].Substring(0, intIndex);

            var maxGroupNumber = 0;
            for (int i = 0; i < T.Length; i++)
            {
                var groupNumberString = Regex.Match(T[i], @"\d+").Value;
                var groupNumber = int.Parse(groupNumberString);

                if (maxGroupNumber < groupNumber)
                { 
                    maxGroupNumber = groupNumber;
                }
            }

            decimal solvedGroupsNumber = 0;
            for (int i = 1; i <= maxGroupNumber; i++)
            {
                var neededLinesList = new List<TaskLine>();

                for (int k = 0; k < T.Length; k++)
                {
                    var groupNumberString = Regex.Match(T[k], @"\d+").Value;
                    var groupNumber = int.Parse(groupNumberString);

                    if (groupNumber == i)
                    {
                        neededLinesList.Add(new TaskLine
                        {
                            Result = R[k],
                            TaskName = T[k]
                        });
                    }

                    
                }

                if (neededLinesList.All(task => task.Result == Ok))
                {
                    solvedGroupsNumber++;
                }
            }

            var result = (solvedGroupsNumber / maxGroupNumber) * 100;

            return (int)result;
        }

        public class TaskLine
        { 
            public string TaskName { get; set; }
            public string Result { get; set; }
        }
    }
}
