using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Interfaces
{
    public interface IDownloader
    {
        void Download(string fileURL);

        void DownloadAsync(string url);
    }
}
