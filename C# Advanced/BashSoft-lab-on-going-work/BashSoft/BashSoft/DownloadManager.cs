using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class DownloadManager
    {
        public static void Download(string fileURL)
        {
            WebClient webClinClient = new WebClient();

            try
            {
                OutputWriter.WriteMessageOnNewLine("Started downloading: ");
                string nameOffile = ExtractNameofFile(fileURL);
                string pathToDownload = SessionData.currentPath + "../../" + nameOffile;

                webClinClient.DownloadFile(fileURL, pathToDownload);
                
                OutputWriter.WriteMessageOnNewLine("Download coplete");

            }
            catch (WebException exception)
            {
                OutputWriter.DisplayException(exception.Message);
            }
        }

        private static string ExtractNameofFile(string fileURL)
        {
            int indexOfLastBackSlash = fileURL.LastIndexOf("/");
            if (indexOfLastBackSlash != - 1)
            {
                
            }
            else
            {
                throw  new WebException(ExceptionMessages.InvalidPath);
            }
            return fileURL.Substring(indexOfLastBackSlash + 1);
        }

        public static void DownloadAsync(string fileURL)
        {
            Task.Run(() => Download(fileURL));
        }
    }
}
