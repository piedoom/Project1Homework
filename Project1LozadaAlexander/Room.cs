using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1LozadaAlexander
{
    //room defines rooms within the shop.  Used for showing where StoreItems are located
    public class Room
    {
        public string Name
        {
            get; set;
        }

        public Room(string name)
        {
            Name = name;
        }
    }
}
