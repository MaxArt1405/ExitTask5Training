using No8.New.Interfaces;
using No8.New.Printers;
using No8.Solution.New.Exceptions;
using No8.Solution.New.Interfaces;
using No8.Solution.New.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.New.Factory
{
    public class Manager : IManager
    {
        private readonly IEnumerable<Printer> listOfPrinters;
        private readonly IRepository Repository;
        private readonly Logger _logger = new Logger();

        public Manager(PrinterRepository storage)
        {
            if (storage is null)
            {
                throw new ArgumentNullException(nameof(storage));
            }
            Repository = storage;
            listOfPrinters = Repository.GetPrinterList();
        }

        public void Add(Printer printer)
        {
            if (printer is null)
            {
                throw new ArgumentNullException(nameof(printer));
            }

            if (!listOfPrinters.Contains(printer))
            {
                Repository.Add(printer);
                _logger.Log("Printer added");
            }
            else
            {
                _logger.Log("Printer already exist");
                throw new RequestForExistAccountException($"{nameof(printer)} already exists");
            }
            Repository.Add(printer);
        }
        public void Remove(Printer printer)
        {
            if (printer is null)
            {
                throw new ArgumentNullException(nameof(printer));
            }

            Repository.Delete(printer.Name);
        }
        public void Save()
        {
            Repository.Save();
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var item in listOfPrinters)
            {
                result += item + "\n";
            }
            return result;
        }

        public IEnumerator<Printer> GetEnumerator()
        {
            return listOfPrinters.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        } 
    }
}
