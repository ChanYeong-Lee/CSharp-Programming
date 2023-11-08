    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11.Delegate_p.Delegate;

namespace _11.Delegate_p
{
    /*********************************************************
     * 대리자 (Delegate)
     * 
     * 특정 매개 변수 목록 및 반환 형식이 있는 함수에 대한 참조
     * 대리자 인스턴스를 통해 함수를 호출할 수 있음
     *********************************************************/

    internal class Delegate
    {
        // <델리게이트 정의>
        // delegate 반환형 델리게이트이름(매개변수들);
        public delegate float DelegateMethod1(float param1, float param2);
        public delegate void DelegateMethod2(string str);

        public static float Plus(float left, float right) { return left + right; }
        public static float Minus(float left, float right) { return left - right; }    
        public static float Multi(float left, float right) { return left * right; }
        public static float Divide(float left, float right) { return left / right; }

        public static void Print(string str) { Console.WriteLine(str); }

      
    }
    internal class Test
    {
        public static void Test1()
        {
            // <델리게이트 사용>
            // 반환형과 매개변수가 일치하는 함수를 델리게이트 변수에 할당
            // 델리게이트 변수를 함수 호출방법과 동일하게 ()를 통해서 호출

            DelegateMethod1 delegate1 = Plus;
            Console.WriteLine(delegate1(20, 10));

            delegate1 = Minus;
            Console.WriteLine(delegate1(20, 10));

            DelegateMethod2 delegate2;
            delegate2 = Print;
            delegate2("Hello World!");
        }
    }
}
