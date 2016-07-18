using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
  public interface IRobot : IChekable
    { 
        string Model { get; }

    }
}
