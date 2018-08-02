using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.New.Printers
{
    public class Canon : Printer
    {
        public Canon(string name, string model) : base(name, model) { }

        protected override void IndividualPrint(Stream file)
        {
            for (int i = 0; i < file.Length; i++)
            {
                // simulate printing
                Console.WriteLine(file.ReadByte());
            }
        }
    }
}
