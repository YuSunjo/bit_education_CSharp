using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//참조로 추가해준다음에 dll을
using MemberLib;

namespace DLL_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member("홍길동", "대한민국");
            WriteLine("이름:{0} 주소 :{1}", member.Name, member.Addr);
            ReadLine();
        }
    }
}

//gac(global cache assemply)  --c-> ms.NET -> assembly만들기
