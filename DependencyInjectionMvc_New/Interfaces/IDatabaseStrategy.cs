using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Interfaces
{
    public interface IDatabaseStrategy
    {
        public void Log(string message);
    }
}
