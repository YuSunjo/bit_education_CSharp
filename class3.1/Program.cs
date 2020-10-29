using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace class3._1
{
    //abstract class Product
    //{
    //    private static int serial = 0;
    //    public string SerialID
    //    {
    //        get
    //        {
    //            return String.Format("{0:d5}", serial++);
    //        }
    //    }
    //    abstract public DateTime ProductDate
    //    {
    //        get; set;
    //    }

    //}
    //class MyProduct : Product
    //{
    //    public override DateTime ProductDate { get; set; }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //추상클래스에서의 프로퍼티
    //        Product product1 = new MyProduct()    //인터페이스 타입 넣음   다형성이 있을 수도 있기 때문에 이런식으로 구현 
    //        { ProductDate = new DateTime(2018, 09, 09) };

    //        WriteLine("Product: {0}, Product Date: {1}", product1.SerialID, product1.ProductDate);

    //        Product product2 = new MyProduct()
    //        { ProductDate = new DateTime(2018, 03, 03) };

    //        WriteLine("Product: {0}, Product Date: {1}", product2.SerialID, product2.ProductDate);


    //    }
    //}
    //--------------------------------------------------------


    //interface INamedValue
    //{
    //    //인터페이스에 있기 때문에 추상프로퍼티 껍데기만 있는거... 
    //    string Name
    //    {
    //        get; set;
    //    }
    //    string Value
    //    {
    //        get; set;
    //    }
    //}
    //class NamedValue : INamedValue
    //{
    //    public string Name
    //    {
    //        get; set;
    //    }
    //    public string Value
    //    {
    //        get; set;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        NamedValue name = new NamedValue() { Name = "이름", Value = "홍길동" };
    //        NamedValue height = new NamedValue() { Name = "키", Value = "170cm" };
    //        NamedValue weight = new NamedValue() { Name = "체중", Value = "80kg" };
    //        WriteLine($"{name.Name}: {name.Value}");
    //        WriteLine($"{height.Name}: {height.Value}");
    //        WriteLine($"{weight.Name}: {weight.Value}");


    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //익명 타입 
    //        var a = new { Name = "홍길동", Age = 20 };
    //        WriteLine($"name: {a.Name} , Age: {a.Age} ");

    //        var b = new { Subject = "수학", Scores = new int[] { 90, 85, 80, 75 } };
    //        Write($"subject: {b.Subject}, scores :");
    //        foreach (var score in b.Scores)
    //        {
    //            Write($"{score}");
    //        }
    //        WriteLine();

    //    }
    //}
    //--------------------------------------------------------



    //class BirthdayInfo
    //{
    //    //public string Name
    //    //{
    //    //    get;set;
    //    //}
    //    public string Name
    //    {
    //        get; set;
    //    } = "Anonymous";
    //    //public DateTime Birthday
    //    //{
    //    //    get;set;
    //    //}
    //    public DateTime Birthday
    //    {
    //        get; set;
    //    } = new DateTime(1, 1, 1);
    //    public int Age
    //    {
    //        //멤버 변수가 없어도 상관없음 
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;    //현재날짜에서 생일 빼고 ticks
    //        }
    //    }
    //}
    //class Program
    //{
    //    //자동구현 property
    //    static void Main(string[] args)
    //    {
    //        //BirthdayInfo birth = new BirthdayInfo()
    //        //{
    //        //    Name = "홍길동",
    //        //    Birthday = new DateTime(1990, 5, 10)
    //        //};
    //        //WriteLine($"Name: {birth.Name}");
    //        //WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
    //        //WriteLine($"Age: {birth.Age}");
    //        BirthdayInfo birth = new BirthdayInfo();
    //        WriteLine($"Name:{birth.Name}");
    //        WriteLine($"birthday:{birth.Birthday.ToShortDateString()}");
    //        WriteLine($"Name:{birth.Age}");

    //        birth.Name = "홍길동";
    //        birth.Birthday = new DateTime(1990, 5, 10);
    //        WriteLine($"Name:{birth.Name}");
    //        WriteLine($"birthday:{birth.Birthday.ToShortDateString()}");
    //        WriteLine($"Name:{birth.Age}");
    //    }
    //}
    //--------------------------------------------------------


    //class BirthdayInfo
    //{
    //    private string name;
    //    private DateTime birthday;

    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }
    //    public DateTime Birthday
    //    {
    //        get
    //        {
    //            return birthday;
    //        }
    //        set
    //        {
    //            birthday = value;
    //        }
    //    }
    //    public int Age
    //    {
    //        //멤버 변수가 없어도 상관없음 
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;    //현재날짜에서 생일 빼고 ticks
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //getter, setter
    //        //property -- 대문자로 시작 
    //        BirthdayInfo birth = new BirthdayInfo();
    //        birth.Name = "홍길동";
    //        birth.Birthday = new DateTime(1990, 5, 10);
    //        WriteLine($"Name: {birth.Name}");
    //        WriteLine($"birthday : {birth.Birthday.ToShortDateString()}");
    //        WriteLine($"Age: {birth.Age}");


    //    }
    //}
    //--------------------------------------------------------


    //interface ILogger
    //{
    //    void WriteLog(string message);
    //}
    //interface IFormattableLogger : ILogger
    //{
    //    void WriteLog(string format, params Object[] args);
    //}
    //class ConsoleLogger : IFormattableLogger
    //{
    //    public void WriteLog(string format, params object[] args)
    //    {
    //        string message = String.Format(format, args);
    //        WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    //    }

    //    public void WriteLog(string message)
    //    {
    //        WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IFormattableLogger logger = new ConsoleLogger();
    //        logger.WriteLog("this is the first writeLog method");
    //        logger.WriteLog("----{0}----", "this is the second writeLog method");

    //    }
    //}


    //--------------------------------------------------------


    //interface ILogger      //--맨앞에 interface라고 I 로 시작함
    //{
    //    void WriteLog(string message);
    //}

    //class ConsoleLogger : ILogger          //상속 말고 implement라고 표현함 
    //{
    //    public void WriteLog(string message)
    //    {
    //        WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    //    }
    //}
    //class FileLogger : ILogger
    //{
    //    private StreamWriter writer;           //file과 process 연결=> stream 
    //    public void WriteLog(string message)
    //    {

    //        writer.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    //    }
    //    public FileLogger(string path)
    //    {
    //        writer = File.CreateText(path);                //
    //        writer.AutoFlush = true;
    //    }
    //}
    //class ClimateMonitor
    //{
    //    private ILogger logger;
    //    public ClimateMonitor(ILogger logger)
    //    {
    //        this.logger = logger;
    //    }
    //    public void start()
    //    {
    //        while (true)
    //        {
    //            Write("온도입력");
    //            string temperature = ReadLine();
    //            if (temperature == "")
    //                break;
    //            logger.WriteLog("현재온도:" + temperature);
    //        }
    //    }
    //}
    //class Program
    //{
    //    //인터페이스 
    //    //--메소드, 이벤트 ,인덱서, 프로퍼티만 가짐 
    //    //--모든것이 public 이다.
    //    static void Main(string[] args)
    //    {
    //        WriteLine("FileLogger Start");
    //        ClimateMonitor monitor = new ClimateMonitor(new FileLogger("C:/temp/mylog.txt"));
    //        monitor.start();

    //        WriteLine("ConsoleLogger Start");
    //        ClimateMonitor monitor2 = new ClimateMonitor(new ConsoleLogger());
    //        monitor2.start();

    //    }
    //}

    //--------------------------------------------------------

    //abstract class AbstractBase
    //{
    //    protected void PrivatetMethodA()
    //    {
    //        WriteLine("AbstractorBase.PrivateMethodA()");
    //    }
    //    public void PublicMehodA()
    //    {
    //        WriteLine("AbstractorBase.PulibcMethodA()");
    //    }
    //    public abstract void AbstractMethodA();
    //}
    //class Derived : AbstractBase
    //{
    //    //추상메소드를 반드시 구현을 해야함 
    //    public override void AbstractMethodA()
    //    {
    //        WriteLine("Derived.AbstractMethodA()");
    //        PrivatetMethodA();
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //추상클래스  --단독으로 객체 생성안되고 상속받은 클래스로 객체만듦 
    //        //사용이유 -- 어떤 기능이 있는데  -- 자식마다 세부기능이 다르기 때문에   -- 인터페이스와 연결
    //        //abstract  ,  override 
    //        //
    //        AbstractBase obj = new Derived();
    //        obj.AbstractMethodA();
    //        obj.PublicMehodA();
    //    }
    //}
}
