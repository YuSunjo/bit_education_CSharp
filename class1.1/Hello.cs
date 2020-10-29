using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace class1._1
{
    class Hello
    {
        enum ColorCode : int { RED = 10, BLUE, GREEN, ORANGE = 100 }
        //static void Main(string[] args)
        //{
            //1.
            //WriteLine("hello world");

            //sbyte a = -10;
            //byte b = 40;
            //WriteLine($"a={a}, b={b}");

            //int e = -10_000_000;
            //uint f = 300_000_000;

            //WriteLine($"a={e}, b={f}");

            //long g = -500_000_000_000;
            //ulong h = 2_000_000_000_000_000;
            //WriteLine($"a={g}, b={h}");

            ////2.
            //byte a = 240;
            //WriteLine($" a={a}");

            //byte b = 0b1111_0000;
            //WriteLine($" a={b}");


            //byte c = 0xF0;
            //WriteLine($" a={c}");


            //uint d = 0x1234_abcd;
            //WriteLine($" a={d}");

            //3 decimal   16(29 자리 까지 표현)
            //float a = 3.1415_3245_4587_3434_3838_79f;
            //double b = 3.1415_3245_4587_3434_3838_79;
            //decimal c = 3.1415_3245_4587_3434_3838_79m;                 //정밀한 계산 할 때 사용

            //WriteLine(a);
            //WriteLine(b);
            //WriteLine(c);

            //string
            //string a = "독도는 우리땅";
            //string b = "대마도도 우리땅";

            //WriteLine(a);
            //WriteLine(b);

            //bool 타입 
            //bool a = true;
            //bool b = false;

            //WriteLine(a);
            //WriteLine(b);

            //object type
            //object a = 123;
            //object b = "123";
            //object c = 123.2;
            //WriteLine($"{ a},{ b},{ c}");

            //5.
            //float a = 69.2454f;
            //WriteLine("a={0}", a);

            //double b = (double)a;
            //WriteLine("b={0}", b);

            //WriteLine("69.2454 == b : {0}", 69.2454 == b);

            //float x = 0.1f;
            //WriteLine("x :{0}", x);

            //double y = (double)x;
            //WriteLine("y : {0}", y);

            //WriteLine("0.1 ==y: {0}", 0.1 == y);

            //문자열과 숫자 변환
            //int a = 123;
            //string b = a.ToString();
            //WriteLine(b);

            //float c = 3.14f;
            //string d = c.ToString();
            //WriteLine(d);

            //string e = "123456";
            //int f = int.Parse(e);
            //WriteLine(f);

            //string g = "1.2345";
            //float h = float.Parse(g);
            //WriteLine(h);

            //상수 
            //const int MAX_INT = 21445245;
            //const int MIN_INT = -21452245;

            //WriteLine(MAX_INT);
            //WriteLine(MIN_INT);

            //enum 
            //WriteLine((int)ColorCode.RED);
            //WriteLine((int)ColorCode.BLUE);
            //WriteLine(ColorCode.GREEN);
            //WriteLine(ColorCode.ORANGE);

            //ColorCode cCode = ColorCode.RED;
            //WriteLine(cCode == ColorCode.BLUE);
            //WriteLine(cCode == ColorCode.RED);

            //?
            //int? a = null;  //Nullable

            //WriteLine(a.HasValue);
            //WriteLine(a != null);

            //a = 3;
            //WriteLine(a.HasValue);
            //WriteLine(a != null);
            //WriteLine(a.Value);

            //var        교제 6p 참고 

            //var a = 20;
            //WriteLine("typr: {0}, value: {1}", a.GetType(), a);

            //var b = 3.14224;
            //WriteLine("typr: {0}, value: {1}", b.GetType(), b);

            //var c = "hello world";
            //WriteLine("typr: {0}, value: {1}", c.GetType(), c);

            //var d = new int[] { 10, 20, 30 };
            //Write("typr: {0}, value:", d.GetType());
            //foreach(var e in d)
            //{
            //    Write("{0} ", e);
            //}
            //WriteLine();

            //문자열
            //string str = "This is string search sample";
            //WriteLine(str);
            //WriteLine();

            //WriteLine("index of 'search' : {0}", str.IndexOf("search"));
            //WriteLine("index of 'h' : {0}", str.IndexOf("h"));

            //WriteLine("StartsWith 'This': {0}", str.StartsWith("This"));
            //WriteLine("StartsWith 'string': {0}", str.StartsWith("string"));

            //WriteLine("EndsWith 'This': {0}", str.EndsWith("This"));
            //WriteLine("EndsWith 'string': {0}", str.EndsWith("sample"));

            //WriteLine("Contains 'search': {0}", str.Contains("search"));
            //WriteLine("Contains 'school': {0}", str.Contains("school"));

            //WriteLine("Replace 'sample' with 'example' : {0}", str.Replace("sample", "example"));

            //
            //string str = "Welcome to the C# world";

            //WriteLine(str.Substring(15, 2));                 //15부터 2개
            //WriteLine(str.Substring(8));                     //8부터 끝까지
            //WriteLine();

            //string[] arr = str.Split(new string[] { " " }, StringSplitOptions.None);   //문자열에서  " "를 구분해서 배열에 넣음 
            //WriteLine("Word count: {0}", arr.Length);

            //foreach(string element in arr)
            //{
            //    WriteLine("{0}", element);
            //}

            //{} 사용
            //string fmt = "{0,-10}{1,-5}{2,20}";
            //WriteLine(fmt, "Type", "Size", "Explain");      //0 옆에 -10은 10칸을 잡는다. 
            //WriteLine(fmt, "byte", "1", "byte타입");
            //WriteLine(fmt, "short", "2", "Explain");
            //WriteLine(fmt, "int", "4", "Explain");
            //WriteLine(fmt, "long", "8", "Explain");


            //WriteLine("10진수: {0:D}", 123);   //D - 십진수
            //WriteLine("10진수: {0:D5}", 123);   //D - 십진수

            //WriteLine("16진수: 0x{0:X}", 0xFF123);   //x - 16진수
            //WriteLine("16진수: 0x{0:X8}", 0xFF123);   //x - 16진수

            //WriteLine("숫자: {0:N}", 123456);
            //WriteLine("숫자: {0:N0}", 123456);

            //WriteLine("고정소수점 : { 0:F}", 123.456);
            //WriteLine("고정소수점 : { 0:F5}", 123.456);

            //WriteLine("공학: {0:E}", 123.456789);

            //
            //string name = "홍길동";
            //int age = 25;
            //WriteLine($"{name,-10}, {age:D3}");

            //name = "김유신";
            //age = 30;
            //WriteLine($"{name}, {age,-10:D3}");

            //name = "박문수";
            //age = 15;
            //WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");

            //
            //if문을 줄이려는 장점 
            //ArrayList a = null;
            //a?.Add("C++");
            //a?.Add("C#");
            //WriteLine($"Count: {a?.Count}");
            //WriteLine($"{a?[0]}");
            //WriteLine($"{a?[1]}");

            //a = new ArrayList();
            //a?.Add("C++");
            //a?.Add("C#");
            //WriteLine($"Count: {a?.Count}");
            //WriteLine($"{a?[0]}");
            //WriteLine($"{a?[1]}");

            //
            //int? num = null;
            //WriteLine($"{num ?? 0}");          //만약 null이면 0을 찍어라 

            //num = 10;
            //WriteLine($"{num ?? 0}");

            //string str = null;
            //WriteLine($"{ str ?? "default"}");

            //str = "i study C#";
            //WriteLine($"{str ?? "default"}");

            //switch
            //Write("요일을 입력하세요(월 화 수 목 금 토 일):");
            //string day = ReadLine();

            //switch (day)
            //{
            //    case "일":
            //        WriteLine("sunday");
            //        break;
            //    case "월":
            //        WriteLine("monday");
            //        break;
            //    case "화":
            //        WriteLine("tuesday");
            //        break;
            //    case "수":
            //        WriteLine("wednesday");
            //        break;
            //    case "목":
            //        WriteLine("thursday");
            //        break;
            //    case "금":
            //        WriteLine("friday");
            //        break;
            //    case "토":
            //        WriteLine("Saturday");
            //        break;
            //    default:
            //        WriteLine("입력하신 글자는 요일이 아닙니다.");
            //        break;


            //switch의 다른 형태
            //object obj = null;

            //string str = ReadLine();
            //if (int.TryParse(str, out int int_num))           //str을 int로 변환에 성공하면 숫자, 아니면 null을 return 해줌 (int.TryParse())자체가 null
            //    obj = int_num;
            //else if (float.TryParse(str, out float float_num))
            //    obj = float_num;
            //else
            //    obj = str;


            //switch (obj)
            //{
            //    case int i:
            //        WriteLine($"{i}는 int 형식입니다.");
            //        break;
            //    case float f:
            //        WriteLine($"{f}는 float 형식입니다.");
            //        break;
            //    default:
            //        WriteLine($"{obj}는 object 형식입니다.");
            //        break;
            //}


            //int[] arr = new int[] { 0, 1, 2, 3, 4 };
            //foreach (int i in arr)            //in 다음에는 반드시 collection 타입
            //{
            //    WriteLine(i);
            //}



            //}
        }
}
