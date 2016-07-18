using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Celebrations
{
    public interface IPet : ICheckable
    {
        string Name { get; }
        
    }
}
