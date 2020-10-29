using Microsoft.SqlServer.Server;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace class6._1
{

    //public class Class
    //{
    //    public string Name { get; set; }
    //    public int[] Score { get; set; }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Class[] arrClass = {
    //            new Class() { Name = "장미반", Score = new int[] { 99, 80, 70, 24 } }
    //    ,
    //            new Class() { Name = "백합반", Score = new int[] { 60, 32, 75, 26, 97 } }
    //    ,
    //            new Class() { Name = "개나리반", Score = new int[] { 80, 72, 35, 26, 97 } }
    //    ,
    //            new Class() { Name = "갈대반", Score = new int[] { 80, 92, 65, 26, 97 } }

    //        };

    //        var classes = from c in arrClass
    //                      from s in c.Score
    //                      where s < 60
    //                      orderby s
    //                      select new
    //                      {
    //                          c.Name,
    //                          Lowest = s,
    //                      };

    //        foreach (var c in classes)
    //            WriteLine($"낙제 : {c.Name} {c.Lowest}");
    //    }
    //--------------------------------------------------------


    //public class Profile
    //{
    //    public string Name { get; set; }
    //    public int Height { get; set; }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Profile[] arrProfile = {new Profile() { Name="sd", Height =186}
    //                                                ,new Profile(){Name="sdsa", Height=177}
    //                                                ,new Profile(){Name="sdsa1", Height=174}
    //                                                ,new Profile(){Name="sdsa2", Height=171}
    //                                                ,new Profile(){Name="sdsa3", Height=165}
    //        };

    //        var profiles = from profile in arrProfile
    //                       where profile.Height < 175
    //                       orderby profile.Height
    //                       select new
    //                       {
    //                           Name = profile.Name,
    //                           InchHeight = profile.Height * 0.393
    //                       };

    //        foreach (var profile in profiles)
    //            WriteLine($"{profile.Name}, {profile.InchHeight}");
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    //LINQ 
    //    //-from 변수 in 원본데이터 절부터 시작 
    //    //where [조건]
    //    //orderby [정렬기준] [ascendign | descending]
    //    //select [추출 데이터]
    //    static void Main(string[] args)
    //    {
    //        int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

    //        var result = from n in numbers
    //                     where n % 2 == 0
    //                     orderby n
    //                     select n;

    //        foreach (int n in result)
    //            WriteLine($"짝수: {n}");
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Predicate<int> Pre = (a) => a > 0 ? true :false;

    //        WriteLine(Pre(-10));

    //    }
    //}
    //--------------------------------------------------------


    ////<Action 대리자>
    ////public delegate TResult Action<out TResult>()
    ////public delegate TResult Action<in T, out TResult>(T arg)
    ////public delegate TResult Action<in T1, in T2, out TResult>(T arg1, T arg2)
    ////...16개 까지 정의 해놓았다.

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Action act1 = () => WriteLine("action()");
    //        act1();

    //        int result = 0;
    //        Action<int> act2 = (x) => result = x * x;
    //        act2(3);
    //        WriteLine($"result : {result}");

    //        Action<double, double> act3 = (x, y) =>
    //         {
    //             double d = x / y;
    //             WriteLine($"action<t1,t2>({x}, {y}) : {d}");
    //         };
    //        act3(10.0, 4.0);
    //    }
    //}
    //--------------------------------------------------------


    ////    <Func 대리자>
    //    //public delegate TResult Func<out TResult>()
    //    //public delegate TResult Func<in T, out TResult>(T arg)
    //    //public delegate TResult Func<in T1, in T2, out TResult>(T arg1, T arg2)
    //    //...16개 까지 정의 해놓았다.

    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Func<int> func1 = () => 10;
    //            WriteLine($"func1(): {func1()}");
    //            Func<int, int> func2 = (x) => x * 2;
    //            WriteLine($"func2(4), {func2(4)}");

    //            Func<double, double, double> func3 = (x,y) => x/y;
    //            WriteLine($"func3(23,6), {func3(23,6)}");

    //        }
    //    }
    //--------------------------------------------------------


    //class Program
    //{
    //    delegate string Concatenate(string[] args);
    //    static void Main(string[] args)
    //    {
    //        string[] strArr = { "ms ", "C# ", "langauage " };
    //        Concatenate concat = (arr) =>
    //        {
    //            string result = "";
    //            foreach (string s in arr)
    //            {
    //                result += s;
    //            }
    //            return result;
    //        };
    //        //Concatenate concat = delegate (string[] arr)
    //        //{
    //        //    string result = "";
    //        //    foreach (string s in arr)
    //        //    {
    //        //        result += s;
    //        //    }
    //        //    return result;
    //        //};

    //        WriteLine(concat(strArr));
    //    }
    //}
    //--------------------------------------------------------

    //람다식

    //class Program
    //{
    //    delegate int Calculator(int a, int b);
    //    static void Main(string[] args)
    //    {
    //        Calculator cal = (a, b) => a + b;
    //        WriteLine($"{4}+ {3} : {cal(3, 4)}");

    //        //Calculator ca = (a, b) =>
    //        //{
    //        //    return a + b;
    //        //};


    //    }
    //}
    //--------------------------------------------------------


    //delegate void EventHandler(string message);
    //class MyNotifier
    //{
    //    public event EventHandler DoAlarm;             
    //    //이벤트 붙이면 해당 딜리게이트가 선언된 클래스 내부에서만 호출 가능함..
    //    public void Get369(int num)
    //    {
    //        int temp = num % 10;
    //        if (temp != 0 && temp % 3 == 0)
    //        {
    //            DoAlarm(string.Format("{0}: 짝", num));
    //        }
    //    }
    //}
    //class Program
    //{
    //    static public void MyHandler(string message)
    //    {
    //        WriteLine(message);
    //    }
    //    static void Main(string[] args)
    //    {
    //        MyNotifier notifier = new MyNotifier();
    //        notifier.DoAlarm += new EventHandler(MyHandler);

    //        for (int i = 1; i < 30; i++)
    //        {
    //            notifier.Get369(i);
    //        }
    //        //notifier.DoAlarm("가나다라");  //오류남 event는 외부에서 선언 안됨 

    //    }
    //}

}
