using System;

namespace lab6ex6
{
    class Program
    {
        public static void findWinner(String[] votes)
        {

            Dictionary<String, int> map =
                        new Dictionary<String, int>();
            foreach (String str in votes)
            {
                if (map.ContainsKey(str))
                    map[str] = map[str] + 1;
                else
                    map.Add(str, 1);
            }


            int maxValueInMap = 0;
            String winner = "";
            foreach (KeyValuePair<String, int> entry in map)
            {
                String key = entry.Key;
                int val = entry.Value;
                if (val > maxValueInMap)
                {
                    maxValueInMap = val;
                    winner = key;
                }


                else if (val == maxValueInMap &&
                    winner.CompareTo(key) > 0)
                    winner = key;
            }
            Console.WriteLine(winner);
        }
        static void Main(string[] args)
        {
            String[] votes = { "john", "johnny", "jackie",
                            "johnny", "john", "jackie",
                            "jamie", "jamie", "john",
                            "johnny", "jamie", "johnny",
                            "john" };

            findWinner(votes);
        }
    }
}
