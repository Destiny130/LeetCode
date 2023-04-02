using System;
using TestCases.Array_LC;
using TestCases.DP_LC;
using TestCases.Math_LC;

namespace TestCases
{
    class Execute
    {
        static void Main()
        {
            //double d0 = 100000, d1 = 100000, d2 = 100000;
            //for (int i = 1; i <= 30; ++i)
            //{
            //    d0 *= 1.05;
            //    d1 *= 1.15;
            //    d2 = d2 * 1.15 + 50000;
            //    Console.WriteLine($"{i}\t\t{d0:F3}\t\t{d1:F3}\t\t{d2:F3}");
            //}

            #region Array

            //new Two_Sum_Test().Execute();
            //new _3Sum_Test().Execute();

            #endregion

            #region DP

            //new Word_Break_Test().Execute();

            #endregion

            #region Math

            //new Reverse_Bits_Test().Execute();

            #endregion

            //string name = "Rick";
            //string intro1 = "My name is " + name;
            //string intro2 = "My name is " + name;
            //Console.WriteLine(intro1 == intro2);
            //Console.WriteLine(AreReferenceEqual(intro1, intro2));

            int loopCount = 1000000;

            long num = 9223372036854775807;

            var pingfang = Math.Pow(num, 2);
            var lifagngen = Math.Sqrt(num);

            DateTime startTime = DateTime.UtcNow;
            int strLen = 0;
            for (int i = 0; i < loopCount; ++i)
            {
                string str = num.ToString();
                strLen = str.Length;
            }
            DateTime endTime = DateTime.UtcNow;
            Console.WriteLine($"str.Length: {strLen}, spent: {(endTime - startTime).TotalMilliseconds} ms");

            startTime = DateTime.UtcNow;
            int len = 0;
            for (int i = 0; i < loopCount; ++i)
            {
                int count = 0;
                long curr = num;
                while (curr > 0)
                {
                    count++;
                    curr /= 10;
                }
                len = count;
            }

            endTime = DateTime.UtcNow;
            Console.WriteLine($"num.Length: {len}, spent: {(endTime - startTime).TotalMilliseconds} ms");


            Console.ReadKey();
        }

        static bool AreReferenceEqual<T>(T first, T second) where T : class
        {
            return first == second;
        }
    }

    public static class Program
    {
        public static void Test()
        {
            Base b = new Base();
            b.Dispose();
            ((IDisposable)b).Dispose();

            Derived d = new Derived();
            d.Dispose();
            ((IDisposable)b).Dispose();

            b = new Derived();
            b.Dispose();
            ((IDisposable)b).Dispose();
        }
    }

    internal class Base : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Base's Dispose");
        }
    }

    internal class Derived : Base, IDisposable
    {
        new public void Dispose()
        {
            Console.WriteLine("Derived's Dispose");
        }
    }
}
