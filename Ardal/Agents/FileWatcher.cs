using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.Agents
{
    public class FileWatcher: IArdalAgent
    {
        private string Folder;

        public FileWatcher(string folder)
        {
            Folder = folder;
        }

        public Task Shutdown()
        {
            throw new NotImplementedException();
        }

        public Task Start()
        {
            throw new NotImplementedException();
        }
    }
}
