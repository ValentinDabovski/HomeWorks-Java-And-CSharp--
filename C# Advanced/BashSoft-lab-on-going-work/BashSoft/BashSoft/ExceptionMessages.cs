using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class ExceptionMessages
    {
        public const string InvalidPath = "The folder/file you are trying to access at the current adress, does not exist!";
        public const string UnauthorizedAccessExceptionMessage = "The folder/file you are trying to get access needs a higher level of rights than you currently have.";
        public const string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";
        public const string ForbiddenSymbolsContainedInName = "The given name contains symbols that are not allowed to be used in names of files and folders";
        public const string UnableToGoHigherInPartitionHierarchy = "Unable to go higher in partition hierarchy";
        public const string UnableToParseNumber = "The sequence you've written is not a valid number.";
    }
}
