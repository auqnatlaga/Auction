using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Auction
    {
        public string status { get; private set; }
        //enum : status (Active; inactive)
        public Item item;
        public int MinIncrease { get; private set; }
        public int MaxIncrease { get; private set;}
        public int CurrentOffer { get; private set; }

        public Auction(string status, Item item)
        {
            this.status = status;
            this.item = item;
            this.MinIncrease = 0;
            this.MaxIncrease = 0;
            this.CurrentOffer = 0;
        }  
        
        //setting offers
        public void setCurrentOffer(int offer)
        {
           this.CurrentOffer = offer;
        }

        //create a specific percentage increase 
         
        
        //show the item
        //let the admin set the status
        //let the bidder set the min max increase 

    }
}
