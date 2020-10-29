using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace class1._1
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a ,int b)
        {
            return a - b;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            int result = Calculator.Plus(2, 5);
            Console.WriteLine(result);

            result = Calculator.Minus(10, 4);
            Console.WriteLine(result);
        }
        
        
    }
}
