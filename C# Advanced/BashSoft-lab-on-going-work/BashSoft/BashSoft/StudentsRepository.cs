using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BashSoft
{

    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;
        private static readonly string pattern = @"\b([A-Z]+[a-zA-Z+#]*_[A-Z][a-z]{2}_)(2014|2015|2016)\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+([0-9][0-9]?|100)\b";

        public static void InitiliazeData(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Readin data...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }

            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        private static void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;

            if (File.Exists(path))
            {
                string[] tokens = File.ReadAllLines(path);
                var regex = new Regex(pattern);
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (!string.IsNullOrEmpty(tokens[i]) && regex.IsMatch(tokens[i]))
                    {
                        var currentMatch = regex.Match(tokens[i]);
                        string course = currentMatch.Groups[1].Value + currentMatch.Groups[2].Value;
                        string student = currentMatch.Groups[3].Value;
                        int mark;
                        int.TryParse(currentMatch.Groups[4].Value, out mark);

                        if (!studentsByCourse.ContainsKey(course))
                        {
                            studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                        }

                        if (!studentsByCourse[course].ContainsKey(student))
                        {
                            studentsByCourse[course].Add(student, new List<int>());
                        }

                        studentsByCourse[course][student].Add(mark);
                    }
                }

                
            }

            isDataInitialized = true;   
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            else
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataNotInitializedExceptionMessage);

            }
            return false;

        }

        private static bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }

            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public static void GetStudentScoreFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossible(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentsMarkEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentsMarkEntry);
                }
            }
        }
    }
}






