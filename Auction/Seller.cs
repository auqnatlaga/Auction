using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public class Seller : User
    {
        public Seller(string name, DateTime birthDate, string address, string contact) : base(name, birthDate, address, contact)
        { }
    }
}

/*
    show items
        categories: Auctioned, ForAuction, ForReview, Rejected

    show AuctionedHistory
        //based on Item status(?) sold:pending;
    
    
*/
