using No8.New;
using No8.New.Printers;
using No8.Solution.New.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.New.Factory
{
    public class PrinterFactory : IPrinterFactory
    {
        public Printer Get(string name, string model, PrinterTypes type)
        {
            switch (type)
            {
                case PrinterTypes.Canon:
                    return new Canon(name, model);
                case PrinterTypes.Epson:
                    return new Epson(name, model);
                default:
                    throw new InvalidOperationException("instance not found");
            }
        }
    }
}
