using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace class5._1
{

    //delegate int Compare(int a, int b);
    //class Program
    //{
    //    static void BubbleSort(int[] dataSet, Compare comparer)
    //    {
    //        int i = 0;
    //        int j = 0;
    //        int temp = 0;
    //        for (i = 0; i < dataSet.Length; i++)
    //        {
    //            for (j = 0; j < dataSet.Length - (i + 1); j++)
    //            {
    //                if (comparer(dataSet[j], dataSet[j + 1]) > 0)
    //                {
    //                    temp = dataSet[j + 1];
    //                    dataSet[j + 1] = dataSet[j];
    //                    dataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 3, 7, 4, 2, 9 };

    //        WriteLine("Ascending sort");

    //        BubbleSort(array, delegate (int a, int b)
    //        {
    //            if (a > b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        });
    //        for (int i = 0; i < array.Length; i++)
    //        {

    //            Write($"{array[i]} ");
    //        }

    //        WriteLine();

    //        WriteLine("Descending sort");
    //        BubbleSort(array, delegate (int a, int b)
    //        {
    //            if (a < b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        });
    //        for (int i = 0; i < array.Length; i++)
    //        {

    //            Write($"{array[i]} ");
    //        }
    //    }
    //}
    //_---------------------------------------------
    //delegate int Compare(int a, int b);
    //class Program
    //{
    //    static void BubbleSort(int[] dataSet, Compare comparer)
    //    {
    //        int i = 0;
    //        int j = 0;
    //        int temp = 0;
    //        for (i = 0; i < dataSet.Length; i++)
    //        {
    //            for (j = 0; j < dataSet.Length - (i + 1); j++)
    //            {
    //                if (comparer(dataSet[j], dataSet[j + 1]) > 0)
    //                {
    //                    temp = dataSet[j + 1];
    //                    dataSet[j + 1] = dataSet[j];
    //                    dataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Compare cpA = delegate (int a, int b)
    //        {
    //            if (a > b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        };
    //        int[] array = { 3, 7, 4, 2, 9 };

    //        WriteLine("Ascending sort");

    //        BubbleSort(array, cpA);
    //        for (int i = 0; i < array.Length; i++)
    //        {

    //            Write($"{array[i]} ");
    //        }

    //        WriteLine();

    //        Compare cpB = delegate (int a, int b)
    //        {
    //            if (a < b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        };

    //        WriteLine("Descending sort");
    //        BubbleSort(array, cpB);
    //        for (int i = 0; i < array.Length; i++)
    //        {

    //            Write($"{array[i]} ");
    //        }


    //    }
    //}
    //--------------------------------------------------------


    ////갑자기 어떤 함수가 필요 할경우 -> 새로 클래스만들어서 사용 or 내 클래스 안에서 만들어서 사용 --> 이럴때 delegate사용

    //class Program
    //{
    //    //익명 메소드를 만들어서 사용할 경우 
    //    delegate int Calculate(int a, int b);
    //    //메소드 만들경우
    //    static int CalSum(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Calculate calc = delegate (int a, int b)
    //        {
    //            return a + b;
    //        };

    //        WriteLine("3+4 : {0}", calc(3, 4));

    //        calc = new Calculate(CalSum);
    //        WriteLine("3+4: {0}", calc(3, 4));
    //        calc = CalSum;
    //        WriteLine("3+4: {0}", calc(3, 4));

    //    }
    //}
    //--------------------------------------------------------

    //delegate void Notify(string message);
    //class Notifier
    //{
    //    public Notify EventOccured;
    //}

    //class EventListener
    //{
    //    private string name;
    //    public EventListener(string name)
    //    {
    //        this.name = name;
    //    }
    //    public void SomethingHappened(string message)
    //    {
    //        WriteLine($"{name}.SomethingHappened: {message}");
    //    }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Notifier notifier = new Notifier();
    //        EventListener listener1 = new EventListener("listen1");
    //        EventListener listener2 = new EventListener("listen2");
    //        EventListener listener3 = new EventListener("listen3");

    //        notifier.EventOccured = listener1.SomethingHappened;
    //        notifier.EventOccured += listener2.SomethingHappened;
    //        notifier.EventOccured += listener3.SomethingHappened;
    //        notifier.EventOccured("you've got mail");
    //        WriteLine();

    //        notifier.EventOccured -= listener2.SomethingHappened;
    //        notifier.EventOccured("download completed");
    //        WriteLine();

    //        Notify notify1 = new Notify(listener1.SomethingHappened);
    //        Notify notify2 = new Notify(listener2.SomethingHappened);
    //        notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
    //        notifier.EventOccured("fired");
    //        WriteLine();

    //        notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
    //        notifier.EventOccured("Game Over");
    //    }
    //}
    //--------------------------------------------------------

    //delegate void OnlineShopping(string location);
    //class Program
    //{
    //    static void OrderGoods(string location)
    //    {
    //        WriteLine($"장바구니내 물건을 {location}으로 가져다 주세요");
    //    }
    //    static void SpecialOrder(string location)
    //    {
    //        WriteLine($"{location}에 사람이 없으면 문앞에 두고 문자주세요");
    //    }
    //    static void Main(string[] args)
    //    {
    //        //delegate를 여러번 사용 가능 
    //        OnlineShopping shopper = new OnlineShopping(OrderGoods) + new OnlineShopping(SpecialOrder);

    //        shopper("우리집");
    //    }
    //}
    //--------------------------------------------------------


    //delegate int Compare<T>(T a, T b);
    //class Program
    //{
    //    static int AscendCompare<T>(T a, T b) where T : IComparable<T>      //메소드가 CompareTo가 있음 
    //    {
    //        return a.CompareTo(b);    //a가 b보다 크면 return 1 같으면 0 작으면 -1
    //    }
    //    static int DescendCompare<T>(T a, T b) where T : IComparable<T>
    //    {
    //        //return b.CompareTo(a);
    //        return a.CompareTo(b) * -1;
    //    }
    //    static void BubbleSort<T>(T[] dataSet, Compare<T> comparer)
    //    {
    //        int i = 0;
    //        int j = 0;
    //        T temp;
    //        for (i = 0; i < dataSet.Length; i++)
    //        {
    //            for (j = 0; j < dataSet.Length - (i + 1); j++)
    //            {
    //                if (comparer(dataSet[j], dataSet[j + 1]) > 0)
    //                {
    //                    temp = dataSet[j + 1];
    //                    dataSet[j + 1] = dataSet[j];
    //                    dataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {

    //        int[] array = { 3, 7, 4, 2, 9 };
    //        WriteLine("Ascending sort");
    //        BubbleSort<int>(array, new Compare<int>(AscendCompare));
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Write($"{array[i]} ");
    //        }
    //        WriteLine();

    //        string[] array2 = { "a", "b" };
    //        WriteLine("Descending sort");
    //        BubbleSort<string>(array2, new Compare<string>(DescendCompare));
    //        for (int i = 0; i < array2.Length; i++)
    //        {
    //            Write($"{array2[i]} ");
    //        }
    //        WriteLine();
    //    }
    //}
    //--------------------------------------------------------


    //delegate int Compare(int a, int b);
    //class Program
    //{
    //    static int AscendCompare(int a, int b)
    //    {
    //        if (a > b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;
    //    }
    //    static int DescendCompare(int a, int b)
    //    {
    //        if (a < b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;
    //    }
    //    static void BubbleSort(int[] dataSet, Compare comparer)
    //    {
    //        int i = 0;
    //        int j = 0;
    //        int temp = 0;
    //        for (i = 0; i < dataSet.Length; i++)
    //        {
    //            for (j = 0; j < dataSet.Length - (i + 1); j++)
    //            {
    //                if (comparer(dataSet[j], dataSet[j + 1]) > 0)
    //                {
    //                    temp = dataSet[j + 1];
    //                    dataSet[j + 1] = dataSet[j];
    //                    dataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        //delegate 로 코드 통채로 인자에 넘겨주고 싶을 때 ...
    //        int[] array = { 3, 7, 4, 2, 9 };

    //        WriteLine("Ascending sort");
    //        BubbleSort(array, new Compare(AscendCompare));
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Write($"{array[i]} ");
    //        }
    //        WriteLine();

    //        WriteLine("Descending sort");
    //        BubbleSort(array, new Compare(DescendCompare));
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Write($"{array[i]} ");
    //        }
    //    }
    //}
    //--------------------------------------------------------


    //인자를 2개 받을 수 있는 메소드를 delegate하겠다. 
    //처음에 return 타입이 int인 delegate를 정의해주고  -> 그것을 객체 부르듯이 불러서 사용한다. 
    //메소드를 대신 실행시켜준다.
    //delegate int Mydelegate(int a, int b);
    //class Calculator
    //{
    //    public int Plus(int a, int b)
    //    {
    //        return a + b;
    //    }
    //    public int Minus(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //delegate 

    //        Calculator cal = new Calculator();
    //        Mydelegate Callback;

    //        Callback = new Mydelegate(cal.Plus);
    //        WriteLine(Callback(3, 4));

    //        Callback = new Mydelegate(cal.Minus);
    //        WriteLine(Callback(8, 4));

    //    }
    //}
    //--------------------------------------------------------


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
    //        catch (FilterableException e) when (e.ErrorNo < 0)
    //        {
    //            WriteLine("음수는 허용 X");
    //        }
    //        catch (FilterableException e) when (e.ErrorNo > 10)
    //        {
    //            WriteLine("10보다 큰수는 X");
    //        }

    //    }
    //}
}
