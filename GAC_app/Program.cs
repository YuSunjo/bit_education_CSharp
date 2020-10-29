using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAC_demo;

namespace GAC_app
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass dc = new DemoClass();
            dc.Foo();
        }
    }
}

//GAC_demo는 캐시에 있는것을 쓰기 때문에  이 파일에 있는 dll을 바꿔줘도 실행이 됨 