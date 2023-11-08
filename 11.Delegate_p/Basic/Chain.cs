using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Delegate_p.Basic
{
    internal class Chain
    {
        // <델리게이트 체인>
        // 델리게이트 안에 += 과 -= 연산자를 사용해 여러 함수를 추가할 수 있다.
        // 이 때, 델리게이트 안이 널값일 수 있어 if문을 추가해준다.
        // = 연산자를 사용하면 이전에 있던 함수들은 없어지고 대입한 함수만 남는다.
        public static void Func1() { Console.WriteLine("Func1"); }
        public static void Func2() { Console.WriteLine("Func2"); }
        public static void Func3() { Console.WriteLine("Func3"); }
        public static void Test1()
        {
            Action action;
            action = Func1;
            action += Func2;
            action += Func3;

            action -= Func2;
            action += Func2;

            action -= Func3;
            action += Func3;

            if (action != null)
            {
                action();
            }
        }


        public static void Func4(string name)
        {
            Console.WriteLine(name);
        }
        public static void Func5(string name)
        {
            Console.WriteLine(name + "굿!");
        }
        public static void Func6(string name)
        {
            Console.WriteLine(name + "최고!");
        }
        public static void Test2(string name)
        {
            Action<string> action;
            action = Func4;

            action += Func5;
            action += Func6;

            if (action != null)
            {
                action(name);
            }
        }
    }
}
