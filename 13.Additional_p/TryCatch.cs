using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Additional
{
    internal class TryCatch
    {
        // <예외 처리>
        // 프로그램이 치명적인 오류로 종료가 될 수 있는 상황에 예외상황을 처리하는 방법
        // 프로그램의 상황에 따라 작업을 진행할 수 없는 경우에 처리할 내용을 정리

        // <try catch finally 문>
        // 예외가 발생할 수 있는 코드들을 실행시키는 구절이며 이 경우 치명적인 오류가 발생하는 경우에도
        // 프로그램 종료를 보류하고 예외처리 구문을 진행
        public static void Test1()
        {
            try
            {
                // 코드 실행 시도 부분
                int[] array = new int[10];
                array[0] = 1;
                array[11] = 2;      // 예외를 발생시키는 코드
            }
            catch (Exception ex)
            {
                // 코드 예외 처리 부분
                Console.WriteLine(ex.Message);	// 예외 발생상황에 대해 출력
            }
            finally     // 생략가능
            {
                // 코드 시도 후 진행하는 부분
            }
        }

        // catch 블록에서 예외의 형식을 지정 가능 
        public static void Test2()
        {
            try
            {
                int[] array = new int[10];
                Random random = new Random();
                int value = random.Next(0, 10);
                if (value > 6)
                {
                    array = null;
                }
                else if (value > 3)
                {
                    array = new int[20];
                }
                // 상황에 따라 불가능하거나 가능할 수 있음
                array[11] = 2;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException");
                Console.WriteLine(ex.Message);
            }
        }


        // <throw>
        // 의도적 예외발생
        // 프로그램이 의도와 다른 방향으로 진행되고 있을 경우 의도적 예외발생을 진행
        public class NumberGenerator
        {
            public enum MonsterType { None, Speed, Tank, Sky }
            MonsterType[] types = new MonsterType[4];

            public MonsterType GetType(int index)
            {
                if (index < 0 || index >= types.Length)
                {
                    // throw 문을 통한 의도적 예외발생
                    throw new IndexOutOfRangeException();
                }
                return types[index];
            }
        }
    }
}