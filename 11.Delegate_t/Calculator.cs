using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Delegate_t
{
    internal class Calculator
    {
        private delegate double Calc(double param1, double param2);
        private Calc? calc;
        private double left;
        private double right;
        private double result;
        private double Add(double left, double right)
        { 
            return left + right;
        }

        private double Sub(double left, double right)
        { 
            return left - right;
        }

        private double Multiply(double left, double right)
        {
            return left * right;            
        }

        private double Divide(double left, double right)
        {
            return left / right;
        }

        public void SetCalculate(double left, char key, double right)
        {
            this.left = left;
            this.right = right;
            this.calc = null;
            switch(key)
            {
                case '+':
                    this.calc=Add;
                    break;
                case '-':
                    this.calc = Sub;
                    break;
                case '*':
                    this.calc = Multiply;
                    break;
                case '/':
                    this.calc = Divide;
                    break;
                default:
                    break;
            }
        }

        public double Equal()
        {
            if (calc == null) { return 0; }
            return calc(left, right);   
        }
    }
}
