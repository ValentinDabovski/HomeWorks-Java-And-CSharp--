using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;


namespace BashSoft
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            //StudentsRepository.InitiliazeData("dataNew");
          //  StudentsRepository.GetStudentScoreFromCourse("Unity", "Ivan");


             InputReader.StartReadingCommands();
            //   IOManager.ChangeDirectoryAbsolute(@"C:\\");
            // IOManager.TraverseDirectory(20); 
            //
            //  Tester.CompareContent(@"C:\Users\ValCoder\Documents\test\test3.txt", @"C:\Users\ValCoder\Documents\test\test3.txt");
            //  IOManager.CreateDirectoryInCurrentFolder("*2");

        }
    }
}

