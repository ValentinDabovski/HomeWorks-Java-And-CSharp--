using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft;


    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading Files...");
            string mismatchPath = GetMisMatchPath(expectedOutputPath);

            string[] actualOutputLines = File.ReadAllLines(userOutputPath);
            string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMatch;
            string[] mistmatches = GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMatch);

            PrintOutPut(mistmatches, hasMatch, mismatchPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }

        private static string GetMisMatchPath(string expectetOutPutPath)
        {
            int indexOf = expectetOutPutPath.LastIndexOf('\\');
            string directoryPath = expectetOutPutPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }

        private static string[] GetLinesWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;
            string[] mistmatches = new string[actualOutputLines.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int i = 0; i < actualOutputLines.Length; i++)
            {
                string actualLIne = actualOutputLines[i];
                string expectedLine = expectedOutputLines[i];

                if (!actualLIne.Equals(expectedLine))
                {
                    output = string.Format($"Mismatch at line {i} -- expected: \"{expectedLine}\", actual: \"{actualLIne}\"");
                    output += Environment.NewLine;
                    hasMismatch = true;
                }

                else
                {
                    output = actualLIne;
                    output += Environment.NewLine;
                }

                mistmatches[i] = output;
            }
            return mistmatches;
        }


        private static void PrintOutPut(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }

                File.WriteAllLines(mismatchesPath, mismatches);
                return;
            }
        }

    }




