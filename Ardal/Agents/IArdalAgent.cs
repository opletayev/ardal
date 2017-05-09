using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ardal.Agents
{
    interface IArdalAgent
    {
        Task Start();
        Task Shutdown();
    }
}
