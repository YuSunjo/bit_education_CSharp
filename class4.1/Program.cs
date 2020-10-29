using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace class4._1
{
    //class FilterableException : Exception
    //{
    //    public int ErrorNo
    //    { get; set; }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        WriteLine("enter number between 0~10");
    //        string input = ReadLine();
    //        try
    //        {
    //            int num = int.Parse(input);
    //            if (num < 0 || num > 10)
    //                throw new FilterableException() { ErrorNo = num };
    //            else
    //                WriteLine($"Output: {num}");
    //        }
    //        catch (FilterableException e ) when (e.ErrorNo<0)
    //        {
    //            WriteLine("음수는 허용 X");
    //        }
    //        catch (FilterableException e ) when (e.ErrorNo >10)
    //        {
    //            WriteLine("10보다 큰수는 X");
    //        }

    //    }
    //}
    //--------------------------------------------------------


    //class InvalidArgumentExcepton : Exception
    //{
    //    public InvalidArgumentExcepton() { }
    //    public InvalidArgumentExcepton(string message) : base(message)
    //    {
    //        WriteLine("오류");
    //    }

    //    public object Argument
    //    {
    //        get; set;
    //    }
    //    public string Range
    //    {
    //        get; set;
    //    }
    //}
    //class Program
    //{
    //    static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
    //    {
    //        uint[] args = new uint[] { alpha, red, green, blue };
    //        foreach (uint arg in args)
    //        {
    //            if (arg > 255)
    //                throw new InvalidArgumentExcepton()
    //                {
    //                    Argument = arg,
    //                    Range = "0~255"
    //                };
    //        }
    //        return (alpha << 24 & 0xFF000000) | (red << 16 & 0x00FF0000)    // 24비트 8*3=> 3바이트 
    //            | (green << 8 & 0x0000FF00) | (blue & 0x000000FF);
    //    }
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            WriteLine("0x{0:X8}", MergeARGB(255, 100, 100, 100));
    //            WriteLine("0x{0:X8}", MergeARGB(1, 165, 190, 125));
    //            WriteLine("0x{0:X8}", MergeARGB(0, 255, 255, 260));
    //        }
    //        catch (InvalidArgumentExcepton e)
    //        {
    //            WriteLine(e.Message);
    //            WriteLine($"Argument: {e.Argument}, Range : {e.Range}");
    //        }
    //    }
    //}
    //--------------------------------------------------------

    //class Program
    //{
    //    static int Divide(int divisor, int dividend)
    //    {
    //        try
    //        {
    //            WriteLine("divide() 시작");
    //            return divisor / dividend;
    //        }
    //        catch(DivideByZeroException e)
    //        {
    //            WriteLine("Divide() 예외발생");
    //            throw e;
    //        }
    //        finally
    //        {
    //            WriteLine("Divide() 종료");
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Write("제수 입력:");
    //            String temp = ReadLine();
    //            int divisor = Convert.ToInt32(temp);

    //            Write("피제수 입력");
    //            temp = ReadLine();
    //            int dividend = int.Parse(temp);

    //            WriteLine("{0}/{1} = {2}", divisor, dividend, Divide(divisor, dividend));
    //        }
    //        catch(FormatException e)
    //        {
    //            WriteLine("에러: " + e.Message);
    //        }
    //        catch (DivideByZeroException e)
    //        {
    //            WriteLine("에러: " + e.Message);
    //        }
    //        finally
    //        {
    //            WriteLine("프로그램 종료");
    //        }
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int? a = null;
    //            int b = a ?? throw new ArgumentNullException();
    //        }
    //        catch (ArgumentNullException e)
    //        {
    //            WriteLine(e);
    //        }
    //        try
    //        {
    //            int[] array = new[] { 1, 2, 3 };
    //            int index = 4;
    //            int value = array[index >= 0 && index < 3 ? index : throw new IndexOutOfRangeException()];
    //        }
    //        catch (IndexOutOfRangeException e)
    //        {
    //            WriteLine(e);
    //        }
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void SimpleFunc(int arg)
    //    {
    //        if (arg <= 10)
    //            WriteLine($"arg: {arg}");
    //        else
    //            throw new Exception("인자값이 10보다 큽니다.");
    //    }
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            SimpleFunc(5);
    //            SimpleFunc(12);
    //        }
    //        catch(Exception e)
    //        {
    //            WriteLine(e.Message);
    //        }

    //    }
    //}
    //--------------------------------------------------------


    //모든 예외 클래스는 system.Exception 클래스를 상속받음 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };
    //        try
    //        {
    //            for (int i = 0; i < 5; i++)
    //                WriteLine(arr[i]);
    //        }
    //        catch(IndexOutOfRangeException e )
    //        {
    //            WriteLine($"예외발생 : ,{e.Message} ");
    //        }
    //        WriteLine("종료");
    //    }
    //}

    //--------------------------------------------------------


    //class MyList<T> : IEnumerable<T>, IEnumerator<T> // IEnumerator<>은 IEnumerator 을 상속받음 
    //{
    //    private T[] array;
    //    private int position = -1;

    //    public MyList()
    //    {
    //        array = new T[3];
    //    }
    //    public T this[int index]
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            if (index >= array.Length)
    //            {
    //                Array.Resize<T>(ref array, index + 1);
    //                WriteLine($"Array resized: {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }
    //    public T Current
    //    {
    //        get
    //        {
    //            return array[position];
    //        }
    //    }
    //    object IEnumerator.Current
    //    {
    //        get
    //        {
    //            return array[position];
    //        }
    //    }
    //    IEnumerator 멤버
    //    public bool MoveNext()
    //    {
    //        if (position == array.Length - 1)
    //        {
    //            Reset();
    //            return false;
    //        }
    //        position++;
    //        return (position < array.Length);
    //    }
    //    IEnumerator 멤버
    //    public void Reset()
    //    {
    //        position = -1;
    //    }
    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            yield return array[i];
    //        }
    //    }
    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //            yield return array[i];
    //    }
    //    IEnumerable 멤버
    //    public void Dispose()
    //    {

    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList<int> list = new MyList<int>();
    //        for (int i = 0; i < 5; i++)
    //            list[i] = i;
    //        foreach (int e in list)
    //            WriteLine(e);


    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Dictionary --> generic 타입  , hashtable --> generic (X)
    //        Dictionary<string, int> dic = new Dictionary<string, int>();
    //        dic["국어"] = 90;
    //        dic["영어"] = 85;
    //        dic["수어"] = 95;
    //        dic["물어"] = 100;
    //        dic["화어"] = 95;

    //        foreach (KeyValuePair<string, int> item in dic)
    //            WriteLine($"{item.Key}: {item.Value}");
    //    }
    //}
    //--------------------------------------------------------

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> list = new List<int>();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list.Add(i);
    //        }
    //        foreach (int i in list)
    //            Write($"{i} ");
    //        WriteLine();
    //        list.RemoveAt(2);

    //        foreach (int i in list)
    //            Write($"{i} ");
    //        WriteLine();
    //        list.Insert(2, 2);
    //        foreach (int i in list)
    //            Write($"{i} ");
    //        WriteLine();

    //    }
    //}
    //--------------------------------------------------------



    //<형식 매개변수 제약>
    //1. where T : struct => T는 값gudtlr
    //static void CopyArray<T>(T[] source, T[] target) where T : struct
    //CopyArray<int>(source, AttributeTargets);

    //2.where T: class => T는 참조형식
    //CopyArray<string>(source, AttributeTargets);

    //3.where T : new () => T는 매개변수가 없는 생성자가 있어야함 
    //public static T CreateInstance<T>() where T: new()
    //{
    //    return new T();
    //}

    //4.where T : 베이스 클래스 이름 => T는 해당 베이스 클래스를 상속한 클래스여야함 
    //static void CopyArray<T>(T[] cource, T[] target) where T : MyList
    //class ChildList: MyList
    //CopyArray<ChildList>(source, AttributeTargets);

    //5. where T : 인터페이스 이름 => T는 해당 인터페이스를 구현해야 함
    //static void CopyArray<T>(T[] cource, T[] target) where T : ILogger
    //class ChildList: ILogger
    //CopyArray<ChildList>(source, AttributeTargets);

    //6. where T : U => T는 U를 상속한 클래스 
    //class BaseArray<U>
    //{
    //    public U[] Array
    //        get; set;
    //    public BaseArray(int size)
    //    {
    //        Array = new U[size];
    //    }
    //    public void CopyArray<T>(T[] source) where T: U
    //    {
    //        source.CopyTo(Array, 0);
    //    }
    //}

    //Generic
    //미리 타입을 정해줘서 타입 체크 , 캐스팅을 줄여줌 
    //class MyList<T>
    //{
    //    private T[] array;
    //    public MyList()
    //    {
    //        array = new T[3];
    //        //array = (T[])new object[3]  --> 자바는 이렇게 해줘야함
    //    }
    //    public T this[int index]
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            if (index >= array.Length)
    //            {
    //                Array.Resize<T>(ref array, index + 1);
    //                WriteLine($"array resized: {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }
    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList<string> str_list = new MyList<string>();
    //        str_list[0] = "abc";
    //        str_list[1] = "def";
    //        str_list[2] = "ghi";
    //        str_list[3] = "jkl";
    //        str_list[4] = "mno";

    //        for (int i = 0; i < str_list.Length; i++)
    //            WriteLine(str_list[i]);

    //        MyList<int> int_list = new MyList<int>();
    //        for (int i = 0; i < 5; i++)
    //            int_list[i] = i;
    //        for (int i = 0; i < int_list.Length; i++)
    //            WriteLine(int_list[i]);
    //    }
    //}
    //--------------------------------------------------------


    //class MyList : IEnumerable, IEnumerator
    //{
    //    private int[] array;
    //    private int position = -1;

    //    public MyList()
    //    {
    //        array = new int[3];
    //    }
    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            if (index >= array.Length)
    //            {
    //                Array.Resize<int>(ref array, index + 1);
    //                WriteLine($"Array resized: {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }
    //    public object Current
    //    {
    //        get
    //        {
    //            return array[position];
    //        }
    //    }
    //    //IEnumerator 멤버
    //    public bool MoveNext()
    //    {
    //        if (position == array.Length - 1)
    //        {
    //            Reset();
    //            return false;
    //        }
    //        position++;
    //        return (position < array.Length);
    //    }
    //    //IEnumerator 멤버
    //    public void Reset()
    //    {
    //        position = -1;
    //    }
    //    //IEnumerable 멤버
    //    public IEnumerator GetEnumerator()
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            yield return array[i];       //yield return -> 잠깐 멈췄다가 실행됨 
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList list = new MyList();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list[i] = i;
    //        }
    //        foreach (int e in list)
    //            WriteLine(e);
    //        WriteLine();


    //    }
    //}
    //--------------------------------------------------------


    //generic 

    //class MyEnumerator
    //{
    //    private int[] numbers = { 1, 2, 3, 4 };
    //    //foreach 쓰면 IEnumerator 타입을 리턴 해줌 
    //    public IEnumerator GetEnumerator()
    //    {
    //        yield return numbers[0];
    //        yield return numbers[1];
    //        yield return numbers[2];
    //        yield return numbers[3];
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new MyEnumerator();
    //        foreach (int i in obj)            //GetEnumerator 메소드 호출 
    //        {
    //            WriteLine(i);
    //        }

    //    }
    //}
    //--------------------------------------------------------


    //인덱서
    //class MyList
    //{
    //    private int[] array;
    //    public MyList()
    //    {
    //        array = new int[3];
    //    }
    //    public int this[int index]               //인덱서가 들어옴 
    //    {
    //        get
    //        {
    //            return array[index];
    //        }
    //        set
    //        {
    //            if (index >= array.Length)
    //            {
    //                Array.Resize<int>(ref array, index + 1);
    //                WriteLine($"Array resized: {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }
    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList list = new MyList();
    //        for (int i = 0; i < 5; i++)
    //            list[i] = i;                    //인덱서 메소드를 호출함   --set
    //        for (int i = 0; i < list.Length; i++)
    //            WriteLine(list[i]);                 //get 

    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Hashtable hashtable = new Hashtable();
    //        hashtable["하나"] = "one";
    //        hashtable["둘"] = "two";
    //        hashtable["셋"] = "three";
    //        hashtable["넷"] = "four";
    //        hashtable["다섯"] = "five";

    //        WriteLine(hashtable["하나"]);
    //        WriteLine(hashtable["둘"]);
    //        WriteLine(hashtable["셋"]);
    //        WriteLine(hashtable["넷"]);
    //        WriteLine(hashtable["다섯"]);

    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue que = new Queue();
    //        que.Enqueue(1);
    //        que.Enqueue(2);
    //        que.Enqueue(3);
    //        que.Enqueue(4);
    //        que.Enqueue(5);

    //        while (que.Count >0)
    //        {
    //            WriteLine(que.Dequeue());
    //        }

    //    }
    //}
    //--------------------------------------------------------

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayList list = new ArrayList();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list.Add(i);
    //        }
    //        foreach (object obj in list)
    //        {
    //            Write($"{obj} ");
    //        }
    //        WriteLine();
    //        list.RemoveAt(2);

    //        foreach (object obj in list)
    //            Write($"{obj} ");
    //        WriteLine();

    //        list.Insert(2, 2);

    //        foreach (object obj in list)
    //        {
    //            Write($"{obj} ");
    //        }
    //        WriteLine();

    //        list.Add("abc");
    //        list.Add("def");

    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            Write($"{list[i]} ");
    //        }
    //        WriteLine();
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[][] jagged = new int[3][];
    //        jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
    //        jagged[1] = new int[] { 10, 20, 30 };
    //        jagged[2] = new int[] { 100, 200 };

    //        foreach (int[] arr in jagged)
    //        {
    //            Write($"lengh : {arr.Length},");
    //            foreach (int e in arr)
    //            {
    //                Write($"{e} ");
    //            }
    //            WriteLine();
    //        }
    //        WriteLine();

    //        int[][] jagged2 = new int[2][]
    //        {
    //            new int[] {100,200},
    //            new int[4] {6,7,8,9}
    //        };
    //        foreach (int[] arr in jagged2)
    //        {
    //            Write($"length: {arr.Length},");
    //            foreach (int e in arr)
    //            {
    //                Write($"{e}");
    //            }
    //            WriteLine();
    //        }
    //    }
    //}
    //--------------------------------------------------------


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };     //int[,] -> 이차원
    //        for (int i = 0; i < arr.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < arr.GetLength(1); j++)
    //                Write($"[{i}, {j}]: {arr[i, j]}");
    //            WriteLine();
    //        }
    //        WriteLine();

    //        int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
    //        for (int i = 0; i < arr2.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < arr2.GetLength(1); j++)
    //            {
    //                Write($"[{i}, {j}]: {arr2[i, j]}");
    //            }
    //            WriteLine();
    //        }
    //    }
    //}
    //--------------------------------------------------------


    ////binary search -- 정렬인 상태에서 해야함 
    //class Program
    //{
    //    private static bool CheckPassed(int score)
    //    {
    //        if (score >= 60)
    //        {
    //            return true;
    //        }
    //        else
    //            return false;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int[] scores = new int[] { 90, 75, 80, 94, 50 };
    //        foreach (int score in scores)
    //            Write($"{score} ");
    //        WriteLine();
    //        Array.Sort(scores);
    //        foreach (int score in scores)
    //        {
    //            Write($"{score} ");
    //        }

    //        WriteLine();
    //        WriteLine($"number of dimesions : {scores.Rank}");           //1차원 배열이여서 1이나옴 

    //        WriteLine("binary search : 80 is at {0}", Array.BinarySearch<int>(scores, 80));
    //        WriteLine("Linear search : 94 is at {0}", Array.IndexOf(scores, 94));

    //        WriteLine($"everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));     //모든것이 true인가? 
    //        WriteLine($"old length of scores: {scores.GetLength(0)}");

    //        Array.Resize<int>(ref scores, 10);  //배열의 길이를 10으로 변경해줌 
    //        WriteLine($"new length of scores : {scores.Length}");

    //        foreach (int score in scores)
    //        {
    //            Write($"{score}");
    //        }
    //        WriteLine();
    //        Array.Clear(scores, 3, 7);         //3부터 clear 
    //        foreach (int score in scores)
    //        {
    //            Write($"{score}");
    //        }
    //        WriteLine();

    //    }
    //}
    //--------------------------------------------------------
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //배열
    //        string[] array1 = new string[3] { "C++", "C#", "Java" };
    //        foreach (string subject in array1)
    //        {
    //            WriteLine($"{subject}");
    //        }
    //        string[] array2 = new string[] { "C++", "C#", "Java" };
    //        foreach (string subject in array2)
    //        {
    //            WriteLine($"{subject}");
    //        }

    //        string[] array3 = { "C++", "C#", "Java" };
    //        foreach (string subject in array3)
    //        {
    //            WriteLine($"{subject}");
    //        }

    //    }
    //    //static void Main(string[] args)
    //    //{
    //    //    int[] arr = new int[] { 1, 2, 3, 4, 5 };
    //    //    WriteLine($"{arr.GetType()}");
    //    //    WriteLine($"{arr.GetType().BaseType}"); 

    //    //}

    //}
}
