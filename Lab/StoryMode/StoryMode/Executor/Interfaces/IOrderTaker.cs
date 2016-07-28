using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interfaces
{
  public  interface IOrderTaker
  {
      void OrderAndTake(string courseName, string comparison, int? studentsToTake = null);
  }
}
