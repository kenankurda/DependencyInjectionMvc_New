using DependencyInjectionMvc_New.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionMvc_New.Repositories
{
    public class LogToTextFile : IDatabaseStrategy
    {

        public void Log(string message, string media)
        {
            string path = @"D:\test\logFile.txt";
            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine(message);
            }
        }
    }
}
