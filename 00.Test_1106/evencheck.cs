using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test_1106
{
    internal static class evencheck
    {
        public static bool EvenCheck(this int num)
        {
            if ((num&1)==1)
            {
                return false;
            }
            return true;
        }
    }
}
