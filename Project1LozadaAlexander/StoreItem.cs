using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1LozadaAlexander
{
    //create an item that is used only by the store; unsellable
    public class StoreItem : Item
    {
        public override void Buy(int amount = 1)
        {
            //do nothing
        }

        public override bool Purchase(int amount = 1)
        {
            //do nothing
            return true;
        }

        public virtual string GetInfo()
        {
            //get info on product
            return ("Store item unsellable.");
        }

        public StoreItem(string room, string name, int priceCents, bool inStock, int stock) : base(name, priceCents, stock)
        {

        }

    }


    //voids are weird shop items
    public class Void : Item
    {

        public bool Antimatter
        {
            get;
            set;

        }

        public virtual string GetInfo()
        {
            //get info on product
            return ("Store item is a black hole, probably.");
        }

        public Void(bool antimatter, string name, int priceCents, bool inStock, int stock) : base(name, priceCents, stock)
        {
            Antimatter = antimatter;
        }

    }
}
