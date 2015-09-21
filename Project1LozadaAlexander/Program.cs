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
            Item couch = new Item("couch", 10000, 20);
            Console.WriteLine();
        }
    }

    public class Manager
    {
        string name;
        //TODO: pull these from a DB
        int[] inventory = new int[1000];        
    }

    //general class for typical items 
    public class Item
    {
        //base class props and fields
        string name;
        int priceCents;
        int stock;

        public string Name { get; set; }
        public int PriceCents { get; set; }
        public int Stock { get; set; }

        //constructor
        public Item(string name, int priceCents, int stock)
        {
            this.name = name;
            this.priceCents = priceCents;
            this.stock = stock;
        }

        public string GetInfo()
        {
            //get info on product
            return ("");
        }

        public void Buy(int amount = 1)
        {
            //buy 1 if no value is supplied
            stock -= amount;
        }

        public void Add(int amount = 1)
        {
            //add 1 if no value is supplied
            stock += amount;
        }
    }

    //create an item that is used only by the store; unsellable
    /*public class StoreItem : Item
    {
        public StoreItem(string name, int priceCents, bool inStock, int stock) : base(name, priceCents, inStock, stock)
        {

        }
    }
    */
}
