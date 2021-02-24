using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class Console
    {
        public static void LoadBanner()
        {
            System.Console.WriteLine($"{Color.Green}\n  ██████╗ ██╗   ██╗███████╗██╗   ██╗███████╗ {Color.Reset}");
            System.Console.WriteLine($"{Color.Green} ██╔═══██╗██║   ██║██╔════╝██║   ██║██╔════╝ {Color.Reset}");
            System.Console.WriteLine($"{Color.Green} ██║   ██║██║   ██║█████╗  ██║   ██║█████╗ {Color.Reset}");
            System.Console.WriteLine($"{Color.Green} ██║▄▄ ██║██║   ██║██╔══╝  ██║   ██║██╔══╝  {Color.Reset}");
            System.Console.WriteLine($"{Color.Green} ╚██████╔╝╚██████╔╝███████╗╚██████╔╝███████╗██╗██╗██╗{Color.Reset}");
            System.Console.WriteLine($"{Color.Green}  ╚══▀▀═╝  ╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝╚═╝╚═╝╚═╝\n\n{Color.Reset}");
        }

        public static void LoadMenu()
        {
            // Menu
            System.Console.WriteLine(" 1. Add guest");
            System.Console.WriteLine(" 2. Delete guest");
            System.Console.WriteLine(" 3. Show the number of guests");
            System.Console.WriteLine(" 4. Find guest by name");
            System.Console.WriteLine(" 5. Print all guests");
            System.Console.WriteLine(" 6. Exit");
        }
    }
}
