    using System;
namespace NOTE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fit fit =new Fit();
            fit.Main();
        }
    }

    public class Fit
    {
        public void Main()
        {
            int[] x = { 1, 10, 30, 50 };
            int[] y = { 84, 200, 560, 1920 };

            double[] coefficients = FitPolynomial(x, y, 3);

            Console.WriteLine("계수 a: " + coefficients[3]);
            Console.WriteLine("계수 b: " + coefficients[2]);
            Console.WriteLine("계수 c: " + coefficients[1]);
            Console.WriteLine("계수 d: " + coefficients[0]);
        }

        static double[] FitPolynomial(int[] x, int[] y, int degree)
        {
            int n = x.Length;
            double[,] matrix = new double[degree + 1, degree + 2];

            for (int i = 0; i <= degree; i++)
            {
                for (int j = 0; j <= degree; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matrix[i, j] += Math.Pow(x[k], i + j);
                    }
                }

                for (int k = 0; k < n; k++)
                {
                    matrix[i, degree + 1] += y[k] * Math.Pow(x[k], i);
                }
            }

            // 가우스 소거법을 사용하여 방정식 풀기
            for (int i = 0; i <= degree; i++)
            {
                double pivot = matrix[i, i];
                for (int j = i; j <= degree + 1; j++)
                {
                    matrix[i, j] /= pivot;
                }

                for (int k = 0; k <= degree; k++)
                {
                    if (k != i)
                    {
                        double factor = matrix[k, i];
                        for (int j = i; j <= degree + 1; j++)
                        {
                            matrix[k, j] -= factor * matrix[i, j];
                        }
                    }
                }
            }

            // 계수 배열 반환
            double[] coefficients = new double[degree + 1];
            for (int i = 0; i <= degree; i++)
            {
                coefficients[i] = matrix[i, degree + 1];
            }

            return coefficients;
        }
    }

}