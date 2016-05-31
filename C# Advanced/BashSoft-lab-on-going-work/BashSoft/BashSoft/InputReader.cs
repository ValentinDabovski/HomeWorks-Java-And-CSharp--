using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class InputReader
    {
        private const string endCommand = "exit";

        public static void StartReadingCommands()
        {

            OutputWriter.WriteMessage($"{SessionData.currentPath} >");
            string input = Console.ReadLine();
            input = input.Trim();

            while (input != endCommand) 
            {
                CommandInterpreter.InterpredCommand(input);
                // Interpred command
                OutputWriter.WriteMessage($"{SessionData.currentPath} >");
                input = Console.ReadLine();
                input = input.Trim();

            }
        }
    }
}   