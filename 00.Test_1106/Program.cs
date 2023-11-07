using _00.Test_1106;

namespace _00.Test_1106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            swap.Swap (ref a  ,ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            int value = 3;
            bool isEven = value.EvenCheck();
            Console.WriteLine(isEven);

            float average = Average.AverageFunc(1,2,3,4);
            Console.WriteLine(average);
        }
    }
}

//<일반화>
//어떤 자료형이던지 두 매개변수를 교체하는 함수인
//public static Swap(ref 왼쪽매개변수, ref 오른쪽매개변수)

//    함수를 만들어보자

//<추가 기능>
//<확장메서드>
//int 자료형에 추가기능을 만들자
//int 값이 짝수인지 아닌지 확인하는
//int value = 3;
//bool isEven = value.IsEven();
//함수를 만들어보자


//    <매개변수 추가기능>
//int매개변수가 몇개 들어오든 상관없이 들어온 매개변수들의 평균을 구하는
//float static Average(int매개변수들);
//함수를 만들어보자
