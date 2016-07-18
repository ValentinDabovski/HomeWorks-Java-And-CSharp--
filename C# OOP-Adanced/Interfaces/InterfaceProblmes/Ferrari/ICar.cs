using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   public interface ICar
    {
       string Model { get; }

       string DriverName { get; }


       string Brake();
       string Gas();

    }
}
