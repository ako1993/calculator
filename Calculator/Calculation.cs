using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation
    {
        public int num1;
        public int num2;
        public Calculation(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Addition(int num1, int num2)
        {
            int solution = num1 + num2;
            Console.WriteLine($"These two numbers added together equal {solution}");
        }

        /*Need functions for subtraction, multiplication, and division*/
    }
}