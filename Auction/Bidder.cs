using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Bidder : User
    {
        public int LastBid { get; set; }
        //public int Offer { get; set; }
        public Bidder(string name, DateTime birthDate, string address, string contact) : base(name, birthDate, address, contact)
        {
            this.LastBid = 0;
            //this.Offer = 0;
        }

        public bool Bid(Auction a, int offer)
        {           
            if ((offer >= a.MinIncrease) && (offer >= a.MaxIncrease))
                {
                    a.setCurrentOffer(offer);
                    return true;
                }  
            else
                return false;
        }
    }
}

