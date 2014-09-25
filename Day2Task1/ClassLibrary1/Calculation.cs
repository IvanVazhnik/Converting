using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Day2Task2
{
    public class Calculation
    {
        
                
        public int NODCalc(int time,params int[] numbers)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int result = Calc(numbers[0], numbers[1]);
                      
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Thread.Sleep(time-ts.Milliseconds);

            return result;
            

        }

        
        
        private static int Calc(int a, int b)
        {
            while (b != 0)
            {
                b = a % (a = b);
            }
            return a;

        }

        private static int Calc(params int[] numbers)
        {

            int a = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                a = Calc(a, i+1);
                
            }

            return a;
        }


        public int GCD(int a, int b)
        {

            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GCD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GCD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GCD(a, b / 2);
            return GCD(b,Math.Abs(a - b));


        }

        public int GCD(params int[] numbers)
        {
            int a = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                a = GCD(i, i + 1);

            }

            return a;


        }



    }
}
