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
        Stopwatch sw = new Stopwatch();
                      
        public int NODCalc(int time, int a, int b)
        {
            sw.Start();
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            while (b != 0)
            {
                b = a % (a = b);
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Thread.Sleep(time - ts.Milliseconds);

            return a;                 
        }

        public int NODCalc(int time,params int[] numbers)
        {
           
            int a = numbers[0];
            for (int i = 0; i < numbers.Length-1; i++)
            {
                a = NODCalc(a, numbers[i + 1]);                
            }
          

            return a;
        }


        public int GCD(int time,int a, int b)
        {
            sw.Start();
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GCD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GCD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GCD(a, b / 2);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Thread.Sleep(time - ts.Milliseconds);

            return GCD(b,Math.Abs(a - b));
        }

        public int GCD(int time,params int[] numbers)
        {
           
            int a = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                a = GCD(a, numbers[i + 1]);
            }
          

            return a;
        }
                
    }
}
