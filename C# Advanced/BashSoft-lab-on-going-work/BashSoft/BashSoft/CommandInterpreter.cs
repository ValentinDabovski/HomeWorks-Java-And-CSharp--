using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class CommandInterpreter
    {

        public static void InterpredCommand(string input)
        {
            string[] data = input.Split(' ');
            string command = data[0];
            switch (command)
            {
                case "open":
                    TryOpenFile(input, data);
                    break;
                case "mkdir":
                    TryCreateDirectory(input, data);
                    break;
                case "ls":
                    TryTraverseFolders(input, data);
                    break;
                case "cmp":
                    TryComapareFiles(input, data);
                    break;
                case "cdRel":
                    TryChangePathRelatively(input, data);
                    break;
                case "cdAbs":
                    TryChangePathAbsolute(input, data);
                    break;
                case "readDb":
                    TryReadDatabaseFromFile(input, data);
                    break;
                case "show":
                    TryShowDatabaseFromFile(input, data);
                    break;

                case "help":
                    TrygGetHelp(input, data);
                    break;
                case "filter":
                    //TODO: implement after funcitonality is implemented
                    break;
                case "order":
                    //TODO: implement after funcitonality is implemented
                    break;
                case "decOder":
                    //TODO: implement after funcitonality is implemented
                    break;
                case "download":
                    TryDownloadRequestedFile(input,data);
                    break;
                case "downloadAsynch":
                    TryDownloadRequestedFileAsync(input,data);
                    break;
                default:
                    DispalyInvalidCommandMessage(input);
                    break;
            }


        }

        private static void TryShowDatabaseFromFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string courseName = data[1];
                StudentsRepository.GetAllStudentsFromCourse(courseName);
            }

            else if (data.Length == 3)
            {
                string courseName = data[1];
                string username = data[2];
                StudentsRepository.GetStudentScoreFromCourse(courseName, username);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void DispalyInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }

        private static void TrygGetHelp(string input, string[] data)
        {
            OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "make directory - mkdir: path "));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "traverse directory - ls: depth "));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "comparing files - cmp: path1 path2"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "change directory - changeDirREl:relative path"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "change directory - changeDir:absolute path"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "read students data base - readDb: path"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "download file - download: path of file (saved in current directory)"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "download file asinchronously - downloadAsynch: path of file (save in the current directory)"));
            OutputWriter.WriteMessageOnNewLine(String.Format("|{0, -98}", "get help – help"));
            OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
            OutputWriter.WriteEmptyLine();
        }

        private static void TryReadDatabaseFromFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string fileName = data[1];
                StudentsRepository.InitiliazeData(fileName);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryChangePathAbsolute(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string aboslutePath = data[1];
                IOManager.ChangeDirectoryAbsolute(aboslutePath);
            }
        }

        private static void TryChangePathRelatively(string input, string[] data)
        {

            if (data.Length == 2)
            {
                string relPath = data[1];
                IOManager.ChangeCurrentDirectoryRelative(relPath);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryComapareFiles(string input, string[] data)
        {
            if (data.Length == 3)
            {
                string firstPath = data[1];
                string secondPath = data[2];

                Tester.CompareContent(firstPath, secondPath);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length == 1)
            {
                IOManager.TraverseDirectory(0);
            }

            else if (data.Length == 2)
            {
                int depth;
                bool hasParsed = Int32.TryParse(data[1], out depth);
                if (hasParsed)
                {
                    IOManager.TraverseDirectory(depth);
                }

                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToParseNumber);
                }
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryCreateDirectory(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string folderName = data[1];
                IOManager.CreateDirectoryInCurrentFolder(folderName);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryOpenFile(string input, string[] data)
        {
            if (data.Length == 1)
            {
                string fileName = data[1];
                Process.Start(SessionData.currentPath + "\\" + fileName);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }

        }

        private static void TryDownloadRequestedFileAsync(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string url = data[1];
                DownloadManager.DownloadAsync(url);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }

        private static void TryDownloadRequestedFile(string input, string[] data)
        {
            if (data.Length == 2 )
            {
                string url = data[1];
                DownloadManager.Download(url);
            }

            else
            {
                DispalyInvalidCommandMessage(input);
            }
        }
    }
}



