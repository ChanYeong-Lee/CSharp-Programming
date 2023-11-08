using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11.Delegate_p.Basic
{
    internal class Generic
    {
        public static float Plus(float x, float y)
        { return x + y; }

        public static int Test(double d1, float f2, string s3) { return 0; }

        public static void Test111(string str) { Console.WriteLine(str); }
        public static void Test222(int iteration, string str)
        {
            for (int i = 0; i < iteration; i++)
            { Console.WriteLine(str); }
        }

        public static void Test333()
        {
            Console.WriteLine("No Return");
        }

        public static void Test1()
        {
            Func<float, float, float> func1 = Plus;

            Func<double, float, string, int> func2 = Test;

            Action<string> func3 = Test111;
            Action<int, string> func4 = Test222;
            Action func5 = Test333;
            func3("HELLO");
            func5();
            func4(3, "hello");
        }
    }
}
