using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Speed_Racing
{
  public class NotEnoughFuelException : Exception
  {
      public NotEnoughFuelException(string message) : base(message)
      {
          
      }
    }
}
