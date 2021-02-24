using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class Guest
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Queue<Guest> guests = new Queue<Guest>();

        public void Add(string name, int age)
        {
            guests.Enqueue(new Guest() { Age = age, Name = name });

            System.Console.WriteLine("Guest added!");
            Thread.Sleep(1000);
            System.Console.Clear();
            Console.LoadBanner();
            Console.LoadMenu();
        }

        public void Remove()
        {
            if(guests.Count == 0)
            {
                System.Console.WriteLine($"There is no guests in queue!");
                Thread.Sleep(2000);
                System.Console.Clear();
                Console.LoadBanner();
                Console.LoadMenu();
            }
            else
            {
                Guest guestLeft = guests.Dequeue();
                System.Console.WriteLine($"Guest left:\n\nName: {guestLeft.Name}\nAge: {guestLeft.Age}");
                Thread.Sleep(2000);
                System.Console.Clear();
                Console.LoadBanner();
                Console.LoadMenu();
            }
        }

        public void PrintItems()
        {
            foreach (Guest guest in guests)
            {
                if(guests.Count == 0)
                {
                    System.Console.WriteLine($"There is no guests in queue!");
                    Thread.Sleep(2000);
                    System.Console.Clear();
                    Console.LoadBanner();
                    Console.LoadMenu();
                } else
                {
                    System.Console.WriteLine("Current Guests: \n");
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine($"Name: {guest.Name}");
                    System.Console.WriteLine($"Age: {guest.Age}\n");
                }
            }

            System.Console.WriteLine("Press ENTER to continue");
            System.Console.ReadLine();
        }

        public int CountItems()
        {
            return guests.Count;
        }

        public void Find(string str)
        {
            System.Console.Clear();
            Console.LoadBanner();
            System.Console.WriteLine("Found guests:\n\n");
            foreach (Guest guest in guests)
            {
                if(guest.Name == str)
                {
                    System.Console.WriteLine("========================");
                    System.Console.WriteLine($"Name: {guest.Name}");
                    System.Console.WriteLine($"Age: {guest.Age}");
                }
            }
            System.Console.WriteLine("Press ENTER to continue");
            System.Console.ReadLine();
        }
    }
}
