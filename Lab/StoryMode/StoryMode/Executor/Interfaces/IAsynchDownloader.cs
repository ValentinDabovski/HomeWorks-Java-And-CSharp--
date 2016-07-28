using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interfaces
{
   public interface IAsynchDownloader
   {
       void DownloadAsync(string fileURL);
   }
}
