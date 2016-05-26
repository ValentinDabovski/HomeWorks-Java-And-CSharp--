using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;
using SimpleJudge;

namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            IOManager.TraverseDirectory(@"C:\Users\ValCoder\Desktop\BashSoft\BashSoft");

            Tester.CompareContent(@"C:\Users\ValCoder\Documents\test\test2.txt", @"C:\Users\ValCoder\Documents\test\test3.txt");
        }
    }
}

