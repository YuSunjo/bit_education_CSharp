using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace class1._1
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            WriteLine($"price: {price}");
        }
    }
    class HelloWorld2
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        //overriding
        static int Plus(int a, int b)
        {
            WriteLine("int plus(int,int)");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            WriteLine("int plus(int,int,int)");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            WriteLine("double plus(double, double)");
            return a + b;
        }
        static double Plus(int a, double b)
        {
            WriteLine("double plus(int, double)");
            return a + b;
        }

        //가변인자 params 
        static int Sum(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Write(",");
                Write(args[i]);
                sum += args[i];
            }
            WriteLine();
            return sum;
        }
        static void PrintProfile(string name, string phone = "")
        {
            WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {

            //int result = Calculator.Plus(2, 5);
            //WriteLine(result);

            //int result2 = Calculator.Minus(result, 4);
            //WriteLine(result2);


            //int x = 3;
            //int y = 5;

            //Console.WriteLine($"x:{x}, y:{y}");
            //Swap(ref x, ref y);
            //Console.WriteLine($"x:{x}, y: {y}");

            ////C에서는 포인터 쓰지만 여기선 ref 



            //Product carrot = new Product();
            //ref int ref_price = ref carrot.GetPrice(); //참조리턴
            //int normal_price = carrot.GetPrice();      //값 리턴

            //carrot.PrintPrice();
            //WriteLine($"ref price : {ref_price}");
            //WriteLine($"normal price : {normal_price}");

            //ref_price = 200;
            //carrot.PrintPrice();
            //WriteLine($"ref price: {ref_price}");
            //WriteLine($"normal price: {normal_price}");      //값만 받은애 
            //    ////그림으로 이해해보기 

            //    //
            //int a = 20;
            //int b = 3;
            //int c;
            //int d;

            //Divide(a, b, out int c, out int d);
            //WriteLine($"a: {a}, b:{b}, a/b:{c},a%b:{d}");
            //out  --  out으로 출력한다고 생각하면 됨 -- 출력 변수(return)를 여러개 받기 위한 함수 



            //    //overloading
            //    //함수들에 static이 없다면 main에서 접근하기 위해서는 객체 생성해서 접근해야함 
            //    //WriteLine(Plus(1, 2));
            //    //WriteLine(Plus(1, 2,3));
            //    //WriteLine(Plus(1.0,2.1));
            //    //WriteLine(Plus(1,2.1));


            //    //가변인자 받기
            //    //int sum = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //    //WriteLine($"SUm: {sum}");


            //    //printProfile
            //    //PrintProfile(name: "이순신", phone: "010-1111-2222");
            //    //PrintProfile(phone: "010-1111-2222",name: "이순신");
            //    //PrintProfile("박찬호", "0202020");
            //    //PrintProfile("이순신", phone: "010-1111-2222");
            //    //PrintProfile(name: "이순신");   //default값이 있으면 생략가능 









        }
    }


}
