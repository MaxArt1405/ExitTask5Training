using System;
using No8.New.Printers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No8.Solution.New.Printers;

namespace No8.New
{
    public interface IPrinterFactory
    {
        Printer Get(string name, string model, PrinterTypes type);
    }
}
