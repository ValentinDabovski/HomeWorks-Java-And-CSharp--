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
        try
        {
            string mismatchPath = GetMisMatchPath(expectedOutputPath);
            string[] actualOutputLines = File.ReadAllLines(userOutputPath);
            string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMatch;
            string[] mistmatches = GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMatch);

            PrintOutPut(mistmatches, hasMatch, mismatchPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }
        catch (FileNotFoundException)
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
        }

        catch(DirectoryNotFoundException)
        {
            OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
        }
       
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
        OutputWriter.WriteMessageOnNewLine("Comparing files...");

        int minOutputLine = actualOutputLines.Length;
        string[] mistmatches = new string[minOutputLine];

        if (actualOutputLines.Length != expectedOutputLines.Length) 
        {
            hasMismatch = true;
            minOutputLine = Math.Min(actualOutputLines.Length, expectedOutputLines.Length);
            OutputWriter.DisplayException(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
        }

        for (int i = 0; i < minOutputLine; i++)
        {
            string actualLIne = actualOutputLines[i].Trim();
            string expectedLine = expectedOutputLines[i].Trim();

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

            try
            {
                File.WriteAllLines(mismatchesPath, mismatches);
            }
            catch (DirectoryNotFoundException)
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }

            return;
        }
        OutputWriter.WriteMessageOnNewLine("Files are indentical. There are no mismatches.");
    }
}
