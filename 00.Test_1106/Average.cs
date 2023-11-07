using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Test_1106
{
    internal static class Average
    {
        public static float AverageFunc(params int[] param)
        {
            int sum = 0;
            for (int i=0;i<param.Length; i++)
            {
                sum += param[i];
            }
            float average = (float)sum / param.Length;
            return average;
        }
    }
}
