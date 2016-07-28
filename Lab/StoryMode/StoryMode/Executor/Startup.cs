using System;
using Executor.Interfaces;
using Executor.Network;
using Executor.IO;
using Executor.IO.Interfaces;
using Executor.Judge;
using Executor.Repository;

namespace Executor
{
    class Startup
    {
        static void Main()
        {
            ITester tester = new Tester();
            IDownloader downloadManager = new DownloadManager();
            IDirectoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositorySorter(), new RepositioryFilter());

            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, downloadManager, ioManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}