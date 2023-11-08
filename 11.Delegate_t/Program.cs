namespace _11.Delegate_t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.SetCalculate(3, '+', 5);
            Console.WriteLine("Result = {0}", calculator.Equal());
            calculator.SetCalculate(3, '5', 5);
            Console.WriteLine("Result = {0}", calculator.Equal());
            calculator.SetCalculate(141, '-', 225);
            Console.WriteLine("Result = {0}", calculator.Equal());
            calculator.SetCalculate(33, '*', 21);
            Console.WriteLine("Result = {0}", calculator.Equal());
            calculator.SetCalculate(51, '/', 5);
            Console.WriteLine("Result = {0}", calculator.Equal());
        }
    }
}






/* 1. Delegate를 이용하여 계산기
 * 계산할 때는 조건문 없이
 * 
 * 2. 체력바 만들기
 * 플레이어 체력바, 몬스터 체력바
 * 
 * Array.Find() int 배열안에 있는 5보다 작은 수를 찾는 기능
*/