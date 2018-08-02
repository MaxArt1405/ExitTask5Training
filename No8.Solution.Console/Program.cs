using No8.New.Events;
using No8.New.Printers;
using No8.Solution.New.Factory;
using No8.Solution.New.Interfaces;
using No8.Solution.New.Printers;
using No8.Solution.New.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.Console
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            PrinterRepository repository = new PrinterRepository();
            Manager manager = new Manager(repository);

            Menu.Show();
            var input = System.Console.ReadKey();
            if(input.Key == ConsoleKey.D1)
            {
                Printer printer = CreatePrinter();
                manager.Add(printer);
                printer.BeginPrint += BegginingPrint;
                printer.EndPrint += EndiningPrint;
                System.Console.WriteLine("Success");
            }
            else
            {
                System.Console.WriteLine("Fail");
            }
        }
        private void DoSomething()
        {
            PrinterRepository repository = new PrinterRepository();
            Manager manager = new Manager(repository);

            Menu.Show();
            while (true)
            {
                var input = System.Console.ReadKey();

                if (input.Key == ConsoleKey.D1)
                {
                    Printer printer = CreatePrinter();
                    manager.Add(printer);
                    printer.BeginPrint += BegginingPrint;
                    printer.EndPrint += EndiningPrint;
                }

                if (input.Key == ConsoleKey.D2)
                {
                    repository.GetPrinterList();
                }

                if (input.Key == ConsoleKey.D3)
                {
                    string name = System.Console.ReadLine();
                    Printer printer = repository.GetPrinterByName(name);
                    printer.BeginPrint += BegginingPrint;
                    printer.EndPrint += EndiningPrint;
                    printer.Print(null);
                }

                if (input.Key == ConsoleKey.D0)
                {
                    break;
                }

                break;
            }
        }

        private static Printer CreatePrinter()
        {
            var factory = new PrinterFactory();

            System.Console.WriteLine("Enter printer name");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("Enter printer model");
            string model = System.Console.ReadLine();

            System.Console.WriteLine("Type:");
            string intype = System.Console.ReadLine();

            Enum.TryParse(intype, true, out PrinterTypes type);

            Printer printer = factory.Get(name, model, type);

            return printer;
        }
        private static void BegginingPrint(object sender, PrintEvent e)
        {
            System.Console.WriteLine($"Принтер {e.Name}, {e.Model} начал печать.");
        }
        private static void EndiningPrint(object sender, PrintEvent e)
        {
            System.Console.WriteLine($"Принтер {e.Name}, {e.Model} закончил печать.");
        }   
    }
}
