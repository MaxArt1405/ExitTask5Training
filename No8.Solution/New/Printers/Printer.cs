using No8.New.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.New.Printers
{
    public abstract class Printer
    {
        private string _name;
        private string _model;

        public Printer(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(value)} is null or empty");
                }
                _name = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(value)} is null or empty");
                }
                _model = value;
            }
        }

        public void Print(Stream file)
        {
            OnBeginPrint(new PrintEvent(Name, Model));

            IndividualPrint(file);

            OnEndPrint(new PrintEvent(Name, Model));
        }

        public override string ToString()
        {
            return $"{Model}.{Name}";
        }

        public event EventHandler<PrintEvent> BeginPrint;

        public event EventHandler<PrintEvent> EndPrint;

        protected virtual void OnBeginPrint(PrintEvent args)
        {
            BeginPrint?.Invoke(this, args);
        }
        protected virtual void OnEndPrint(PrintEvent args)
        {
            EndPrint?.Invoke(this, args);
        }
        protected abstract void IndividualPrint(Stream file);
    }
}
