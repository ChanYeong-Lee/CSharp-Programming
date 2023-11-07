using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Additional
{
    internal class StringClass
    {
        // <string>
        // 문자열은 텍스트를 나타내는 데 사용되는 char의 순차적 집합

        public static void Test1()
        {
            // string 사용
            string str = "abcde";
            Console.WriteLine(str);     // output : abcde

            // string은 char의 순차적 집합으로 표현 : 배열처럼 한글자에 접근가능
            Console.WriteLine(str[1]);  // output : b
            Console.WriteLine(str[3]);  // output : d

            // 단, 배열식으로 접근하여 문자를 변경 불가
            // str[1] = 'a';			// error : 문자열의 배열접근은 읽기전용
        }

        // <string의 불변성(Immutable)>
        // string은 특징상 다른 기본자료형과 다르게 크기가 정해져 있지 않은 기본자료형
        // Why? string은 char의 집합이므로 char의 갯수에 따라 크기가 유동적
        // 따라서, string은 런타임 당시에 크기가 결정되며 그 크기가 일정하지 않음
        // 이에 string은 기본자료형과 다르게 구조체가 아닌 클래스로 구현되어 있음 (런타임시 할당받은 메모리는 힙영역을 사용)
        // 단, 기본자료형과 같이 값형식을 구현하기 위해 string 클래스에 처리를 값형식처럼 동작하도록 구현
        // 이를 구현하기 위해 string 간의 대입이 있을 경우 참조에 의한 주소값 복사가 아닌 깊은 복사를 진행
        // 결과적으로 데이터 자체를 복사하는 값형식을 구현하기 위해 한번 string이 설정되면 변경할 수 없도록하는 '불변성'을 가짐

        public static void Test2()
        {
            string str = "abced";       // 힙영역에 abced 문자열을 저장하며 이를 str이 참조함
            str = "abc";                // 새로운 힙영역에 abc 문자열을 저장하며 이름 str이 참조함
            str = str + "123";          // 새로운 힙영역에 abc123 문자열을 저장하며 이를 str이 참조함

            string str2 = str;          // class 이지만 string은 값형식처럼 사용되어야 하기 때문에
                                        // 힙영역에 abc123 문자열을 복사하여 str2가 참조하도록 함	
        }

        // <메모리 파편화>
        // string 이 불변성 특징을 가지므로 새로운 데이터를 string에 할당할 때마다 기존 데이터는 버려짐
        // 이 버려지는 힙영역의 데이터는 가비지컬렉터의 대상이 되며, 이를 반복적으로 진행할 경우 가비지컬렉터에 부담이 됨
        // 여러 string의 할당을 반복적으로 변경하는 경우를 주의해야 프로그램의 안정성을 높일 수 있음
        public static void Test3()
        {
            // 문자열 붙이기 사용
            // 권장하지 않는 방법
            Console.WriteLine("abc" + 123 + "def");
            // "abc123def" 문자열을 얻어내기 위해 "abc", "def", "abc123" 이 힙영역에 버려지게 됨

            // string Format
            Console.WriteLine(String.Format("abc{0}def", 123));
            // string.Format은 가비지컬렉터에 부담되지 않도록 설계됨

            // string 보간
            Console.WriteLine($"abc{123}def");
            // string.Format의 간단한 표현방식

            // Console의 문자열 오버로딩
            Console.WriteLine("abc{0}def", 123);
            // Console.WriteLine의 문자열 출력방식을 달리하면 가비지컬렉터에 부담되지 않도록 설계됨


            string str = "";
            // 문자열 반복 사용
            // 권장하지 않는 방법
            for (int i = 0; i < 10; i++)
            {
                str += i;       // 반복마다 힙영역에 데이터를 버리게 됨
            }

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i);   // 일정 버퍼를 사용하는 방식으로 가비지컬레터에 부담되지 않도록 설계
            }
            str = sb.ToString();
        }
    }
}