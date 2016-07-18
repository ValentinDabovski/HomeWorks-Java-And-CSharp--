using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  interface IPerson
    {

        string Name { get; }
        int Age { get; }
    }
}
