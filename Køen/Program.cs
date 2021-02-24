using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    class Program
    {
        public static string guestName { get; set; }
        public static int guestAge { get; set; }

        public static Guest guest = new Guest();

        static void Main(string[] args)
        {
            System.Console.Clear();
            Console.LoadBanner();
            Console.LoadMenu();

            while(true)
            {
                System.Console.Write("\nEnter your choice: ");
                try
                {
                    int choice = int.Parse(System.Console.ReadLine());
                

                    switch (choice)
                    {
                        case 1:
                            System.Console.Clear();
                            Console.LoadBanner();
                            try
                            {
                                System.Console.WriteLine("Add Guest\n"); System.Console.Write("Name: "); guestName = System.Console.ReadLine(); System.Console.Write("Age: "); guestAge = int.Parse(System.Console.ReadLine());
                            }
                            catch { System.Console.Clear(); Console.LoadBanner(); Console.LoadMenu(); break; }
                            guest.Add(guestName, guestAge);
                            break;


                        case 2:
                            System.Console.Clear();
                            Console.LoadBanner();
                            guest.Remove();
                            break;

                        case 3:
                            System.Console.Clear();
                            Console.LoadBanner();
                            System.Console.WriteLine($"There are {guest.CountItems()} number of guests");
                            Thread.Sleep(2000);
                            System.Console.Clear();
                            Console.LoadBanner();
                            Console.LoadMenu();
                            break;

                        case 4:
                            System.Console.Clear();
                            Console.LoadBanner();
                            try
                            {
                                System.Console.WriteLine("Enter guest name:\n"); System.Console.Write("Name: "); guestName = System.Console.ReadLine();
                            }
                            catch { System.Console.Clear(); Console.LoadBanner(); Console.LoadMenu(); break; }
                            guest.Find(guestName);
                            System.Console.Clear();
                            Console.LoadBanner();
                            Console.LoadMenu();
                            break;

                        case 5:
                            System.Console.Clear();
                            Console.LoadBanner();
                            guest.PrintItems();
                            System.Console.Clear();
                            Console.LoadBanner();
                            Console.LoadMenu();
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            System.Console.WriteLine("Invalid option");
                            Thread.Sleep(1000);
                            System.Console.Clear();
                            Console.LoadBanner();
                            Console.LoadMenu();
                            break;
                    }

                }
                catch { System.Console.Clear(); Console.LoadBanner(); Console.LoadMenu(); }

            }
        }
    }
}
