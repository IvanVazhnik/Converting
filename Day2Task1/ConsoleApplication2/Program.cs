using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2Task1;
using Day2Task2;


namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Converter c = new Converter();
            Calculation cc = new Calculation();


            Console.WriteLine(c.ConvertNumToP(39, 2));
            Console.ReadLine();
            Console.WriteLine(cc.NODCalc(1000, 1071, 462));
            Console.ReadLine();
            Console.WriteLine(cc.GCD(1000, 1071,462));
            Console.ReadLine();
            Console.WriteLine(cc.GCD(1000,1071,462,462,42));  
            Console.ReadLine();


        }
    }
}
