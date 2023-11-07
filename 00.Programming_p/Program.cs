using System;

namespace _00.Programming_p
{
    internal class Program
    {
        /* Main 함수
         * 
         * 프로그램의 시작지점이 되는 함수
         * 모든 C# 프로그램은 Main함수가 1개만 있어야 함
         */
        static void Main(string[] args)
        {
            // 프로그램은 Main함수부터 순서대로 처리됨

            /* Console 클래스
             * 
             * 콘솔 프로그램을 다루기 위해 사용ㅎ는 클래스
             * Console.WriteLine    : 콘솔에 출력하고 줄바꿈
             * Console.Write        : 콘솔에 출력하고 줄을 바꾸지 않음
             * Console.ReadLine     : 콘솔을 통해 한 줄 입력 받음
             * Console.ReadKey      : 콘솔을 통해 키 입력 받음
             */
            Console.WriteLine("Hello, World!");

            Console.Write("콘솔읕 통해 한 줄 입력 : ");
            Console.ReadLine();
            Console.WriteLine("입력이 완료되었습니다.");

            Console.Write("콘솔을 통해 키 입력 : ");
            Console.ReadKey();
            Console.WriteLine("\n입력이 완료되었습니다.");
        }
    }
}