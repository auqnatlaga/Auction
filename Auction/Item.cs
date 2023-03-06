using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Item
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int BasePrice { get; set; }

        public Item(string itemName, string description, int basePrice)
        {
            this.ItemName = itemName;
            this.Description = description;
            this.BasePrice = basePrice;
        }

        //set item by seller
    }
}
