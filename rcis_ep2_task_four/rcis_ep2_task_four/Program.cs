using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            int resultNumb = 0;
            Number number = new Number("iii");
            Dictionary <char, int> numbsSymb = new Dictionary <char, int>()
            {
                { 'I', 1    },
                { 'V', 5    },
                { 'X', 10   },
                { 'L', 50   },
                { 'C', 100  },
                { 'D', 500  },
                { 'M', 1000 }
            };

            for (int i = 0; i < number.numb.Count; ++i)
            {
                if (i + 1 < number.numb.Count && IsSubtractive(number.numb[i], number.numb[i + 1], numbsSymb))
                {
                    resultNumb -= numbsSymb[number.numb[i]];
                }
                else
                {
                    resultNumb += numbsSymb[number.numb[i]];
                }
            }

            Console.WriteLine(resultNumb);
        }
        
        public static bool IsSubtractive(char c1, char c2, Dictionary <char, int> map)
        {
            return map[c1] < map[c2];
        }
    }
}