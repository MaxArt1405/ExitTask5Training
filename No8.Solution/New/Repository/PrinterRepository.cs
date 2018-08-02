using No8.New.Printers;
using No8.Solution.New.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.New.Repository
{
    public class PrinterRepository : IRepository
    {
        private List<Printer> Storage;
        public PrinterRepository() { Storage = new List<Printer>(); }

        public void Add(Printer item) => Storage.Add(item);
        public void Delete(string name)
        {
            Printer printer = Storage.Find(x => x.Name.Contains(name));
            Storage.Remove(printer);
        }
        public IEnumerable<Printer> GetPrinterList()
        {
            return Storage;
        }
        public Printer GetPrinterByName(string name)
        {
            Printer printer = Storage.Find(x => x.Name.Contains(name));
            return printer;
        }
        public void Save()
        {

        }
        public void Update(Printer item)
        {

        }
    }
}
