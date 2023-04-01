using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите номер задания: ");
            switch (Console.ReadLine()!)
            {
                case "1": TaskOne(); break;
                case "2": TaskTwo(); break;
                case "3": TaskThree(); break;
                
                default: Console.WriteLine("Такого задания нет. "); break;
            }
        }

        static void TaskOne()
        {
            string j = "ab";
            string s = "aabbccd";
            int result = 0;
            
            for (int i = 0; i < j.Length; ++i)
            {
                for (int k = 0; k < s.Length; ++k)
                {
                    if (j[i] == s[k])
                    {
                        ++result;
                    }
                }
            }
            Console.WriteLine(result);
        }

        static void TaskTwo()
        {
            List<int> candidates = new List<int>() {10,1,2,7,6,1,5};
            int target = 8;
            candidates.Sort();

            TaskTwoFunk(new List<int>(), candidates, target, new List<List<int>>());
        }

        static void TaskTwoFunk(List<int> combination, List<int> candidates, int target, List<List<int>> result)
        {
            if (combination.Sum() == target)
            {
                bool isSpecial = true;
                for (int i = 0; i < result.Count; ++i)
                {
                    if (Enumerable.SequenceEqual(result[i], combination)) isSpecial = false;
                }

                if (isSpecial)
                {
                    result.Add(combination);
                    Console.Write($"[");
                    for (int i = 0; i < combination.Count; ++i) Console.Write($" {combination[i]} ");
                    Console.WriteLine($"]");
                }
            }

            if (combination.Sum() >= target) return;

            for (int i = 0; i < candidates.Count; ++i)
            {
                var newArray = new List<int>();
                for (int k = i + 1; k < candidates.Count; ++k) newArray.Add(candidates[k]);
                var reCombination = new List<int>(combination) { candidates[i] };
                TaskTwoFunk(reCombination, newArray , target, result);
            }
        }
        
        static void TaskThree()
        {
            int[] array = new[] { 1, 1, 34, 24, 5, 345, 6, 7, };
            Console.WriteLine(TaskThreeFunk(array));
        }
        static bool TaskThreeFunk(int[] array)
        {
            return array.Length != array.Distinct().Count() ? true : false;
        }
    }
}
