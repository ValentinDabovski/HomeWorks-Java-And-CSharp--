using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;


namespace BashSoft
{
    class StartUp
    {
        static void Main(string[] args)
        {
              IOManager.ChangeDirectoryAbsolute(@"C:User\");
               IOManager.TraverseDirectory(20);
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            //
            //  Tester.CompareContent(@"C:\Users\ValCoder\Documents\test\test3.txt", @"C:\Users\ValCoder\Documents\test\test3.txt");
            //  IOManager.CreateDirectoryInCurrentFolder("*2");




        }
    }
}

