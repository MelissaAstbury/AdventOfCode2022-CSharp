namespace AdventOfCode2022.Day1
{
    public class CalorieCounting
    {
        public int CalculateMaxCalorie(string text)
        {
            IDictionary<int, int> groupTotals = new Dictionary<int, int>();
            var key = 0;
            string[] listOfNums = text.Split("\n");

            foreach (var item in listOfNums)
            {
                string cleanItem = item.Replace("\n", "");
                if (cleanItem != "")
                {
                    if (groupTotals.ContainsKey(key))
                    {
                        groupTotals[key] += int.Parse(item);
                    }
                    else
                    {
                        groupTotals.Add(key, int.Parse(item));
                    }
                }
                else
                {
                    key++;
                }
            }

            var maxValue = groupTotals.Values.Max();

            foreach(KeyValuePair<int, int> group in groupTotals.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", group.Key, group.Value);
            };

            return maxValue;




            // 1st ATTEMPT

            //var answer = 0;
            //string[] groupedNums = text.Split("\n\n");

            //foreach (var group in groupedNums)
            //{
            //    string cleanItem = group.Replace("\n", "");

            //    //Get totals of the group
            //    int sumOfNums = cleanedGroup.Sum(x => Convert.ToInt32(x));
            //    if (answer < sumOfNums)
            //    {
            //        answer = sumOfNums;
            //    }

            //}

            //return 0;
        }
    }
};