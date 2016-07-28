﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Executor.Exceptions;
using Executor.Interfaces;
using Executor.IO.Interfaces;
using Executor.Network;
using Executor.Repository;
using Executor.Judge;

namespace Executor.IO.Commands
{
    class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data, ITester tester, IDatabase repository,
                                                            IDownloader downloadManager, IDirectoryManager ioManager)
            : base(input, data, tester, repository, downloadManager, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string fileName = this.Data[1];
            Process.Start(SessionData.currentPath + "\\" + fileName);
        }
    }
}
