using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public interface ICitizen : ICheckable
    {
        string Name { get; }
        int Age { get; }
        string Id { get; }
      
    }
}
