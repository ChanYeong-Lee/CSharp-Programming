using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Additional
{
    internal static class ExtensionMethod
    {
        // <확장메서드>
        // 클래스의 원래 형식을 수정하지 않고도 기존 형식에 함수를 추가할 수 있음
        // 상속을 통하여 만들지 않고도 추가적인 함수를 구현 가능

        /// <summary>
        /// 문자열의 단어수 확인 함수
        /// </summary>
        /// <param name="str">문자열</param>
        /// <returns>단어수</returns>
        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }

        /// <summary>
        /// 문자열의 단어수 확인 함수
        /// </summary>
        /// <param name="str">문자열</param>
        /// <param name="spliter">단어 구분자</param>
        /// <returns>단어수</returns>
        public static int WordCount(this string str, char[] spliter)
        {
            return str.Split(spliter).Length;
        }

        public static void Test1()
        {
            string str = "hello world";

            // 확장메서드를 통하여 기본 string에 없는 함수를 사용 가능
            Console.WriteLine(str.WordCount());
            Console.WriteLine(str.WordCount(new char[] { ' ', 'l' }));
        }

        public class Player
        {
            public string name;
        }

        public static string GetName(this Player player)
        {
            return player.name;
        }

        public static void Test2()
        {
            Player player = new Player();
            string name1 = GetName(player);
            string name2 = player.GetName();
        }
    }
}