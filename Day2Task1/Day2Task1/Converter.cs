using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task1
{
    public class Converter
    {


        public string ConvertNumToP(int number, int p)
        {
            string result = ConvertToP(number, p);
            
            return result;
        }

        private static string ConvertToP(int number, int p)
        {


            string result = "";
            while (number > 0.1)
            {
                int devided = 0;
                devided = number % p;
                if (devided < 10)
                {
                    result += Convert.ToString(devided);
                }
                else if (devided > 9)
                {
                    switch (devided)
                    {
                        case 10:
                            result += "A";
                            break;
                        case 11:
                            result += "B";
                            break;
                        case 12:
                            result += "C";
                            break;
                        case 13:
                            result += "D";
                            break;
                        case 14:
                            result += "E";
                            break;
                        case 15:
                            result += "F";
                            break;
                        default:
                            result += Convert.ToString(devided);
                            break;
                    }
                }

                number = number / p;
            }

            string output = new string(result.ToCharArray().Reverse().ToArray());
            
            return output;
        }
        

    }
}
