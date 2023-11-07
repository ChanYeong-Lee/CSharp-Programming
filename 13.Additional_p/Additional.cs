using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Additional
{
    internal class Additional
    {
        // C#에는 많은 기능이 있으며 있는 기능을 사용해 주는 것이 베스트
        // C#에서 제공되는 기능들은 훨씬 최적화가 잘 되어 있는 경우가 많음

        public static void Test1()
        {
            // of 연산자
            // 변수의 프로그래밍적 외 정보를 추출하는 방법
            int intValue = 20;

            Console.WriteLine(nameof(intValue));    // output : intValue
            Console.WriteLine(sizeof(int));         // output : 4
        }

        public static void Test2()
        {
            // 기본자료형의 메서드
            // 기본자료형은 구조체 또는 클래스로 구성됨, 이 구조체와 클래스 안에 메서드로 기능이 구현됨
            string str = "abc def";
            str.ToLower();          // 소문자 변환
            str.ToUpper();          // 대문자 변환
            str.Split(' ');         // 문자열 나누기
            str.Replace('a', 'z');  // 문자 교체

            int[] array = { 1, 2, 3, 4, 5 };
            array.Max();            // 최대값
            array.Min();            // 최소값
            array.Average();        // 평균값
        }

        public static void Test3()
        {
            // 기본자료형의 static 메서드
            // 기본자료형은 구조체 또는 클래스로 구성됨, 이 구조체와 클래스 안에 메서드로 기능이 구현됨
            int.Parse("12");                // int 형변환

            String.Compare("abc", "abd");   // 문자열 비교

            int[] array = { 5, 2, 1, 4, 3 };
            Array.Sort(array);              // 배열 정렬
            Array.Reverse(array);           // 배열 반전
        }
    }
}