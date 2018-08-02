using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.New.Events
{
    public class PrintEvent : EventArgs
    {
        public readonly string Name;
        public readonly string Model;

        public PrintEvent(string name, string model)
        {
            Name = name;
            Model = model;
        }
    }
}
