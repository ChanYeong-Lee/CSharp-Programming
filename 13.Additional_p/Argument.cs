using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Additional
{
    internal class Argument
    {
        // <Named Parameter>
        // 함수의 매개변수 순서와 무관하게 이름을 통해 호출
        public void Func1(int iParam, float fParam, string strParam) { }

        public void Test1()
        {
            // 함수 호출시 이름을 명명하고 순서와 상관없이 호출 가능
            Func1(strParam: "3", iParam: 1, fParam: 2f);
        }

        // <Optional Parameter>
        // 함수의 매개변수 초기값을 갖고 있다면, 함수호출시 생략하는 것을 허용하는 방법
        public void Func2(int param1, int param2 = 3, int param3 = 5) { }   // 초기값이 있는 경우 미리 할당
                                                                            // public void Func2(int param1 = 2, int param2) { }				// error : 초기값이 있는 매개변수는 마지막에 놓아야 함

        public void Test2()
        {
            Func2(3);           // Func2(3, 3, 5)
            Func2(3, 5);        // Func2(3, 5, 5)
            Func2(3, 5, 7);     // Func2(3, 5, 7)
        }

        // <Params Parameter>
        // 매개변수의 갯수가 정해지지 않은 경우, 매개변수의 갯수를 유동적으로 사용
        public void Func3(params int[] param) { }

        public static int Sum(params int[] param)
        {
            int sum = 0;
            for (int i =0; i< param.Length; i++) 
            {
                sum+= param[i]; 
            }
            return sum;
        }

        public void Test3()
        {
            Func3(1, 3, 5, 7, 9);
            Func3(3, 5, 7);
            Func3();

            int a = Sum(1, 3, 4, 5, 7);
            int b = Sum(1, 3, 4);
        }

        // <in & out Parameter>
        // 매개변수를 입력전용, 출력전용으로 설정
        public void FuncIn(in int param)
        {
            // param = 20;		// error : 입력전용 매개변수에는 저장 불가
        }

        public void FuncOut(out int param)
        {
            // 함수종료 전까지 출력전용 매개변수에 저장하지 않을 경우 오류
            param = 10;
        }

        public void Test4()
        {
            int inValue;
            // FuncIn(a);			// error : 초기화되지 않은 변수를 in 매개변수로 사용 불가
            inValue = 10;
            FuncIn(in inValue);     // in 키워드를 통해 입력을 위한 매개변수 전달

            int outValue;           // 초기화되지 않은 변수도 사용 가능 (함수 안에서 데이터 할당이 진행됨)
            FuncOut(out outValue);  // out 키워드를 통해 출력을 위한 매개변수 전달
        }
    }
}