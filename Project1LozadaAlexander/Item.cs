using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1LozadaAlexander
{
    //general class for typical items 
    public class Item
    {
        //base class props and fields
        //string name;
        //int priceCents;
        //int stock;

        public string Name { get; set; }
        public int PriceCents { get; set; }
        public int Stock { set; get; }

        //constructor
        public Item(string name, int priceCents, int stock)
        {
            Name = name;
            PriceCents = priceCents;
            Stock = stock;
        }

        public virtual string GetInfo()
        {
            //get info on product
            return ("");
        }

        public virtual bool Purchase(int amount = 1)
        {
            //if amount is 0 or less or amount trying to be purchased is more than stock, return false
            if (Stock >= 0 && Stock >= amount)
            {
                //buy 1 if no value is supplied
                Stock -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Buy(int amount = 1)
        {
            //add 1 if no value is supplied
            Stock += amount;
        }
    }
}
