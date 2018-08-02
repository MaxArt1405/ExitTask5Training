using No8.New.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.New.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Printer> GetPrinterList();
        Printer GetPrinterByName(string name);
        void Add(Printer item);
        void Delete(string name);
        void Save();
        void Update(Printer item);
    }
}
