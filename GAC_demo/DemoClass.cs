using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAC_demo
{
    public class DemoClass
    {
        public void Foo()
        {
            Console.WriteLine("Foo!!!");
            Console.ReadLine();
        }
    }
}

//visual studio cmd 관리자 권한으로 실행해서 gacutil /i <dll파일 이름> 해서 어셈블리 캐시 추가 

