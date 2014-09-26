using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Task1
{
    class InputValueCheck
    {


        public bool PValueCheck(int p)
        {

            if (p > 1 && p < 17)
            {
                return true;
            }
            else
                return false;

        }


    }
}
