using No8.Solution.New.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.New.Factory
{
    public class Logger : ILog
    {
        private readonly string path = "Log.txt";

        public void Log(string message)
        {
            File.AppendText(path).Write(message);
        }
    }
}
