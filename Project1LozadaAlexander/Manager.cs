using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1LozadaAlexander
{
    public class Manager
    {
        public string Name { get; set; }
        public List<Item> inventory = new List<Item>();
        public List<Room> rooms = new List<Room>();
        public List<StoreItem> storeinventory = new List<StoreItem>();
        //constructor
        public Manager(string name)
        {
            Name = name;
        }

        //add an item to the product array
        public void Add(Item i)
        {
            inventory.Add(i);
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        //purchase an item from the list.  
        //The first number specifies the position, the second number gives the amount.  
        //The default number to buy is 1 if none is specified
        //returns true if success
        public bool Purchase(int position, int amount = 1)
        {
            Item modify = inventory[position - 1];
            if (modify.Purchase(amount))
            {
                //remove if success, but all sold out
                if (modify.Stock <= 0)
                {
                    inventory.RemoveAt(position - 1);
                }
                return true;
            }
            else
            {    
                return false;
            }
        }

        //list all items in the array with an index number
        public string ListIndex()
        {
            StringBuilder index = new StringBuilder();
            for (int i = 0; i < inventory.Count; i++)
            {
                index.Append((i+1) + ":    ");
                index.Append("Name: " + inventory[i].Name + "    ");
                index.Append("Price: $" + (float)inventory[i].PriceCents/100 + "    ");
                index.Append("Stock: " + inventory[i].Stock + "\n");
            }

            return index.ToString();
        }

        public string ListRooms()
        {
            StringBuilder index = new StringBuilder();
            for (int i = 0; i < rooms.Count; i++)
            {
                index.Append((i + 1) + ":    ");
                index.Append("Name: " + rooms[i].Name + "\n");
            }

            return index.ToString();
        }


        //get a list object of the inventory for other processing usage
        public List<Item> GetInventoryList()
        {
            return inventory;
        }

        //get inventory as a printable string
        /*public string GetInventory()
        {
            //TODO: make pretty
            return String.Concat(inventory.Select(o => o.Name + " " + ((float)(o.PriceCents)) / 100 + " " + o.Stock + "\n"));
        }*/

        public string GetItem(int i)
        {
            return (inventory[i].Name + " " + (float)inventory[i].PriceCents / 100 + " " + inventory[i].Stock);
        }

        //get all info about store
        /*public string GetInfo()
        {
            return Name + "\n--------------\n" + GetInventory();
        }
        */


    }
}
