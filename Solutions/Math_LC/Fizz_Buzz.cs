using System.Collections.Generic;

namespace Solutions.Math_LC
{
    public class Fizz_Buzz
    {
        /*
        Write a program that outputs the string representation of numbers from 1 to n.
        But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        */

        public IList<string> FizzBuzz(int n)
        {
            IList<string> ans = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    ans.Add("FizzBuzz");
                else if (i % 3 == 0)
                    ans.Add("Fizz");
                else if (i % 5 == 0)
                    ans.Add("Buzz");
                else
                    ans.Add(i.ToString());
            }
            return ans;
        }

        //Without mod function
        public IList<string> FizzBuzz_1(int n)
        {
            IList<string> list = new List<string>();
            string fbs = "FizzBuzz", fs = "Fizz", bs = "Buzz";
            for (int i = 1, f = 1, b = 1; i <= n; ++i, ++f, ++b)
            {
                if (f == 3 && b == 5)
                {
                    list.Add(fbs);
                    f = 0;
                    b = 0;
                }
                else if (b == 5)
                {
                    list.Add(bs);
                    b = 0;
                }
                else if (f == 3)
                {
                    list.Add(fs);
                    f = 0;
                }
                else {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
    }
}
