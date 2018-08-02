using No8.New.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.New.Interfaces
{
    public interface IManager : IEnumerable<Printer>
    {
        void Add(Printer obj);
        void Remove(Printer obj);
        void Save();
    }
}
