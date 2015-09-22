using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1LozadaAlexander
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager("Alex's Shop");

            //seed application
            manager.Add(new Item("couch", 50010, 2));
            manager.Add(new Item("bed", 20042, 3));
            manager.Add(new Item("lamp", 2003, 7));
            manager.Add(new Item("chair", 4099, 5));
            manager.AddRoom(new Room("Main Room"));

            bool cont = true;
            while (cont){

                Console.WriteLine("Commands: (p)urchase, (i)nventory, (r)eturnitem, (l)istrooms, (a)ddroom");

                string cmd = Console.ReadLine();

                //purchase
                if (cmd == "purchase" || cmd == "p")
                {
                    Console.WriteLine(manager.ListIndex());
                    Console.Write("Enter the index number of the item you would like to purchase: ");
                    int ind = int.Parse(Console.ReadLine());

                    Console.Write("Enter the amount of the item you would like to purchase: ");
                    int amount = int.Parse(Console.ReadLine());

                    if (manager.Purchase(ind, amount))
                    {
                        Console.WriteLine("Success.");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong.  Did you enter a value higher than the item had in stock?");
                    }
                    
                }

                if (cmd == "inventory" || cmd == "i")
                {
                    Console.WriteLine(manager.ListIndex());
                }

                if (cmd == "listrooms" || cmd == "l")
                {
                    Console.WriteLine(manager.ListRooms());
                }

                if (cmd == "addroom" || cmd == "a")
                {
                    Console.WriteLine("I don't know why a customer is telling us what rooms we have, but go ahead, I guess!\n\nWhat's the name of the room you found?");
                    string roomName = Console.ReadLine();
                    manager.AddRoom(new Room(roomName));
                }

                if (cmd == "returnitem" || cmd == "r")
                {
                    Console.Write("Sorry to hear you're returning something.  We don't use receipts, so tell us what the item is and we'll return it for you. \n\nWhat was the name of the item? ");
                    string name = Console.ReadLine();

                    Console.Write("And what about price in cents? ");
                    int priceCents = int.Parse(Console.ReadLine());

                    Console.Write("And how many items are you returning today? ");
                    int stock = int.Parse(Console.ReadLine());


                    Console.WriteLine("Great, your item has been returned.");

                    Item returnItem = new Item(name, priceCents, stock);
                    manager.Add(returnItem);
                }

            }

        }
    }

}
