using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Cache;

namespace class2._1
{
    class StaticField
    {
        public static int count = 0;
        public static void ShowCount()
        {
            WriteLine($"static.count {count}");
        }
    }
    class classA
    {
        public classA()
        {
            StaticField.count++;
        }
    }
    class classB
    {
        public classB()
        {
            StaticField.count++;
        }
    }

   class ShallowDeepCopy
    {
        public int Field1;
        public int Field2;
        public ShallowDeepCopy DeepCopy()
        {
            ShallowDeepCopy newClass = new ShallowDeepCopy();
            newClass.Field1 = Field1;
            newClass.Field2 = Field2;

            return newClass;


        }
    }
    class Employee
    {
        private string name;
        private string position;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPosition(string position)
        {
            this.position = position;
        }
        public string GetPosition()
        {
            return position;
        }
    }

    class ThisConstructor
    {
        private int a, b, c;

        public ThisConstructor()
        {
            a = 1111;
            WriteLine("ThisConstructor()");
        }
        public ThisConstructor(int b): this()        // this()를 먼저 실행하라 initialize  -- 문법적으로 : -- 은 -- 을 먼저 실행하고 밑에를 실행하라 
        {
            this.b = b;
            WriteLine("ThisConstructor(int)");
        }
        public ThisConstructor(int b, int c) : this(b)        //this(b)를 먼저 실행하라 
        {
            this.c = c;
            WriteLine("ThisConstructor(int, int)");
        }
        public void PrintFields()
        {
            WriteLine($"a:{a}, b:{b}, c: {c}");
        }
    }
    class Parent
    {
        protected string name;
        public Parent()
        {
            name = "김철수";
            WriteLine($"{ this.name}.Parent()");
        }
        public Parent(string name)
        {
            this.name = name;
            WriteLine($"{this.name}.Parent(string)");
        }
        ~Parent()
        {
            WriteLine($"{this.name}.~Parent()");
        }
        public void ParentMethod()
        {
            WriteLine($"{this.name}.ParentMethod()");
        }
    }
    class Child : Parent
    {
        public Child()                     // : base() 이것을 자동으로 생성   -- 상속은 무조건 부모의 객체를 만들어 부모의 생성자를 생성한다. 
        {
            WriteLine($"{this.name}.Child()");
        }
        public Child(string name) : base(name)   //부모의 클래스 : base  
        {
            WriteLine($"{this.name}.Child(string)");
        }
        ~Child()
        {
            WriteLine($"{this.name}.~Child()");
        }
        public void ChildMethod()
        {
            WriteLine($"{this.name}.ChildMethod()");
        }
    }


    class Mammal
    {
        public void Nurse()
        {
            WriteLine("Nursing~~");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            WriteLine("Barking");
        }
    }
    class Human:Mammal
    {
        public void Speak()
        {
            WriteLine("Speaking");
        }
    }

    partial class AAA
    {
       public void Method1()
        {
            WriteLine("Method1()");
        }
        public void Method2()
        {
            WriteLine("Mehhod2()");
        }
    }
    partial class AAA
    {
        public void Method3()
        {
            WriteLine("Method3()");
        }
        public void Method4()
        {
            WriteLine("Method4()");
        }
    }
    public static class EnhancedInteger                //확장 메소드를 만들기 위해 class 에도 static사용 
    {                                                  //이미 있는 클래스에 메소드를 추가해서 사용하기 위해 만듦
        public static int Square(this int input)                  //(this Car) 이런식으로 이미있는 클래스 사용 
        {
            return input * input;
        }
        public static int Power(this int input, int exponent)
        {
            int result = input;
            for(int i=1; i<exponent; i++)
            {
                result *= input;
            }
            return result;
        }
    }

    struct Point3D
    {
        public int x;
        public int y;
        public int z;
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return string.Format($"{x} ,{y}, {z}");
        }
    }

    class Program
    {
        static string ToLowerString(string str)
        {
            var arr = str.ToCharArray();
            //char[] arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);             // 덧셈해줬기 때문에 (char) 씀 
            }
            return new string(arr);
            //답변-- arr 은 캐릭터 배열   string객체에 생성자 오버로드 되어있음(msdn)참고 캐릭터배열을 넣으면
        }
        //static void Main(string[] args)
        //{
        //    //로컬함수 
        //    //c# 에서는 로컬함수만 있음  -- 특정 메소드 안에만 선언  java는 안에 클래스를 만듦 (inner class)
        //    //로컬함수는 - 하나의 매소드 안에서만 사용하려고 
        //    WriteLine(ToLowerString("Hello"));
        //    WriteLine(ToLowerString("World"));
        //    WriteLine(ToLowerString("C# Programming"));
        //}

        //static void Main(string[] args)
        //{
        //    Car mycar = new Car();
        //    Car yourcar = new Car("녕ㄹ", "안");

        //    mycar.ShowStatus();
        //    yourcar.ShowStatus();
        //}
        //static 개념 잘 잡기!!!!
        //만약 count에 static 없애서 해보기 count =0이 나옴 --> 다 따로 작동하기 때문에 
        //static void Main(string[] args)
        //{

        //    StaticField.ShowCount();

        //    new classA();
        //    new classA();
        //    new classB();
        //    new classB();
        //    StaticField.ShowCount();

        //}

        //얉은 복사 -- 객체 인자에 참조타입을 줘서 필드에 접근할 때 
        //깊은 복사 
        //static void Main(string[] args)
        //{
        //    WriteLine("Shallow Copy");
        //    ShallowDeepCopy source = new ShallowDeepCopy();
        //    source.Field1 = 10;
        //    source.Field2 = 20;

        //    ShallowDeepCopy target = source;
        //    target.Field2 = 30;
        //    WriteLine($"{source.Field1} {source.Field2}");
        //    WriteLine($"{target.Field1} {target.Field2}");

        //    WriteLine("Deep Copy");
        //    ShallowDeepCopy deepSource = new ShallowDeepCopy();
        //    deepSource.Field1 = 10;
        //    deepSource.Field2 = 20;

        //    ShallowDeepCopy deepTarget = deepSource.DeepCopy();
        //    deepTarget.Field2 = 30;
        //    WriteLine($"{deepSource.Field1} {deepSource.Field2}");
        //    WriteLine($"{deepTarget.Field1} {deepTarget.Field2}");

        //}


        //static void Main(string[] args)
        //{
        //    Employee e1 = new Employee();
        //    e1.SetName("홍길동");
        //    e1.GetName();
        //    e1.SetPosition("부장");
        //    e1.GetPosition();

        //}

        //static void Main(string[] args)
        //{
        //    ThisConstructor a = new ThisConstructor();
        //    a.PrintFields();
        //    ThisConstructor b = new ThisConstructor(2);
        //    b.PrintFields();
        //    ThisConstructor c = new ThisConstructor(2, 3);
        //    c.PrintFields();

        //}
        //접근제한자  - public , protected , private, internal , protected internal 
        //internal : 같은 어셈블리에 있는 코드에서만 public으로 접근가능 -- 어셈블리에 있는것 접근가능  : default값  dll도 하나의 어셈블리
        //protected internal : 같은 어셈블리에 있는 코드에서 protected로 접근 가능 
        //static void Main(string[] args)
        //{
        //    Parent parent = new Parent("홍길동아버지");
        //    parent.ParentMethod();
        //    WriteLine();

        //    Child child = new Child("홍길동");
        //    child.ParentMethod();
        //    child.ChildMethod();
        //    WriteLine();

        //    Child child2 = new Child();
        //    child2.ParentMethod();
        //    child.ChildMethod();
        //    WriteLine();

        //}

        //sealed  -- 클래스의 상속을 불가능하게 만듦 

        //
        //static void Main(string[] args)
        //{
        //    Mammal mammal = new Mammal();
        //    mammal.Nurse();
        //    WriteLine();

        //    mammal = new Dog();
        //    mammal.Nurse();
        //    WriteLine();

        //    //Dog dog = (Dog)mammal;
        //    //dog.Nurse();
        //    //dog.Bark();
        //    //WriteLine();

        //    if(mammal is Dog)
        //    {
        //        Dog dog = (Dog)mammal;
        //        dog.Nurse();
        //        dog.Bark();
        //        WriteLine();
        //    }

        //    mammal = new Human();
        //    mammal.Nurse();
        //    WriteLine();

        //    //Human human = (Human)mammal;
        //    //human.Nurse();
        //    //human.Speak();

        //    Human human = mammal as Human;      //만약 human타입이면 바꿔주고 아니면 null을 리턴한다. 
        //    if (human != null)
        //    {
        //        human.Nurse();
        //        human.Speak();
        //    }
        //    else
        //    {
        //        WriteLine("human is not human");
        //    }

        //}

        //overridding
        //static void Main(string[] args)
        //{
        //    Car gasolineCar = new GasolineCar("소나타", "가솔린엔진");
        //    gasolineCar.drive();
        //    Car hybridCar = new HybridCar("프리우스", "가솔린엔진, 전기모터");
        //    hybridCar.drive();
        //    //만약 virtual 안쓰고 new를 썼을 경우 부모 객체로 생성 못함. 
        //    //GasolineCar gasolineCar = new GasolineCar("소나타", "가솔린엔진");
        //    //gasolineCar.drive();
        //    //HybridCar hybridCar = new HybridCar("프리우스", "가솔린엔진, 전기모터");
        //    //hybridCar.drive();

        //}

        //Configuration
        //static void Main(string[] args)
        //{
        //    Configuration config = new Configuration();
        //    config.SetConfig("Version", "v5.0");
        //    config.SetConfig("Size", "655,324 kB");

        //    WriteLine(config.GetConfig("Version"));
        //    WriteLine(config.GetConfig("Size"));

        //    config.SetConfig("Version", "V5.1");
        //    WriteLine(config.GetConfig("Version"));
        //}

        //partial   -- 그래픽 이용한 코드에서 핵심!!
        //static void Main(string[] args)
        //{
        //    AAA a = new AAA();
        //    a.Method1();
        //    a.Method2();
        //    a.Method3();
        //    a.Method4();
        //}
        //확장메소드
        //static void Main(string[] args)
        //{
        //    WriteLine($"3^2: {3.Square()}");
        //    WriteLine($"3^4: {3.Power(4)}");
        //    WriteLine($"2^10: {2.Power(10)}");
        //}

        //구조체 
        //-구조체는 값형식(클래스는 참조형식)
        //-선언만으로도 생성가능 (NewsStyleUriParser 로 생성시 heap영역에 생성)
        //-DeepCopy , 매개변수 없는 생성자 선언 불가능 , - 상속 불가능 
        //static void Main(string[] args)
        //{
        //    Point3D point1;
        //    point1.x = 10;
        //    point1.y = 20;
        //    point1.z = 30;
        //    WriteLine(point1.ToString());

        //    Point3D point2 = new Point3D(100, 200, 300);
        //    Point3D point3 = point2;
        //    //ref Point3D point3 = ref point2;
        //    point3.z = 400;

        //    WriteLine(point2.ToString());
        //    WriteLine(point3.ToString());   

        //}

        //튜플 
        //1. unnamed tuple
        //var a = (123, 456);
        //WriteLine($"{a.Item1}, {a.Item2}");
        //2.named tuple
        //var a = (Name:123, Age:456);
        //WriteLine($"{a.Name}, {a.Age}");
        //3.튜플 분해
        //var a = (Name: "홍길동", HttpCacheAgeControl: 20);
        //var (name, age) = a;
        //WriteLine($"{name}, {age}");
        //4.튜플 무시
        //var (name, _) = b;
        //WriteLine($"{name}");

        //static void Main(string[] args)
        //{
        //    var a = ("홍길동", 20);
        //    WriteLine($"{a.Item1}, {a.Item2}");
        //    var b = (Name: "이순신", Age: 40);
        //    WriteLine($"{b.Name}, {b.Age}");

        //    //var (name, age) = b;
        //    //WriteLine($"{name}, {age}");
        //    //b = a;
        //    //WriteLine($"{b.Name}, {b.Age}");




        //}



    }
}
