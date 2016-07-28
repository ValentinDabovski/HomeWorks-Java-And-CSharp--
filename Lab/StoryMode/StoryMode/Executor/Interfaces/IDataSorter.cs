using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interfaces
{
    public interface IDataSorter
    {
        void PrintStudents(Dictionary<string, double> studentsSorted);
    }
}
