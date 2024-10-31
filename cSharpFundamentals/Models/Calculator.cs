using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpFundamentals.Models
{
    public class Calculator
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Div(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Power(int x, int y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pow}");
        }
    }
}