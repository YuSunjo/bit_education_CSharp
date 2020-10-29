using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class7._1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    //--------------------------------------------------------

    //class MainApp :Form
    //{
    //    static void Main(string[] args)
    //    {
    //        MainApp form = new MainApp();
    //        form.Click += new EventHandler(
    //            (sender, eventArgs) =>
    //            {
    //                Console.WriteLine("Closing window");
    //                Application.Exit();
    //            });

    //        Console.WriteLine("starting window Application");
    //        Application.Run(form);                            // 여기서 블록킹 되어있음 

    //        Console.WriteLine("exiting window Application");
    //        Console.ReadLine();
    //    }
    //}
    //--------------------------------------------------------

    //class MyFrom : Form
    //{

    //}
    //class MainApp 
    //{
    //    static void Main(string[] args)
    //    {
    //        MyFrom form = new MyFrom();
    //        form.Click += new EventHandler(             //delegate(Click)
    //            (sender, eventArgs) =>                    //람다식 
    //            {
    //                Application.Exit();
    //            });
    //        Application.Run(form);
    //    }
    //}
}
