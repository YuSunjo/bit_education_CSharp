using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace class6._2
{
    class Program
    {
        static Boolean setStop = false;

        static void BlueFlag()
        {
           while(!setStop)
            {
                WriteLine("청기");
                Thread.Sleep(10);
            }
            WriteLine("추가작업");
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(BlueFlag));

            WriteLine("Start thread");
            thread.Start();

            Thread.Sleep(100);
            WriteLine("stop thread...");
            setStop = true;
            WriteLine("waiting until thread stop");
            thread.Join();

            WriteLine("finish");
        }
    }
    //--------------------------------------------------------


    //class Program
    //{
    //    //static void BlueFlag()
    //    //{
    //    //    for(int i=0; i<10; i++)
    //    //    {
    //    //        WriteLine($"청기");
    //    //        Thread.Sleep(10);
    //    //    }
    //    //}
    //    static void BlueFlag()
    //    {
    //        try
    //        {
    //            while(true)
    //            {
    //                WriteLine("청기");
    //                Thread.Sleep(10);
    //            }    
    //        }
    //        catch (ThreadAbortException e)
    //        {
    //            WriteLine(e);
    //            Thread.ResetAbort();
    //        }
    //        finally
    //        {
    //            WriteLine("리소스 해제");
    //        }
    //        WriteLine("추가작업");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Thread thread = new Thread(new ThreadStart(BlueFlag));

    //        WriteLine("start");
    //        thread.Start();

    //        Thread.Sleep(10);

    //        WriteLine("aborting thread");
    //        thread.Abort();

    //        WriteLine("waiting until thread top");
    //        thread.Join();
    //        WriteLine("finished");
    //    }
    //    //static void Main(string[] args)
    //    //{
    //    //    Thread thread = new Thread(new ThreadStart(BlueFlag));

    //    //    WriteLine("start thread...");
    //    //    thread.Start();

    //    //    for(int i=0; i<10; i++)
    //    //    {
    //    //        WriteLine($"백기");
    //    //        Thread.Sleep(10);
    //    //    }
    //    //    WriteLine("waiting until thread stop");
    //    //    thread.Join();

    //    //    WriteLine("finish");
    //    //}
    //}
}
