using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution.Console
{
    internal class Menu
    {
        public static void Show()
        {
            System.Console.WriteLine("Select your choice:");
            System.Console.WriteLine("1:Add new printer");
            System.Console.WriteLine("2:List printers");
            System.Console.WriteLine("3:Print on the printer by Name");
            System.Console.WriteLine("0:Exit");
        }
    }
}
