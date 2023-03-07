using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
  public class Admin:User
  {
    public Admin(string name, DateTime birthDate, string address, string contact) : base(name, birthDate, address, contact)
        { }
  }
}

/*
  each item created will instantly be in for review
      //can the dictionary key value be an enum?
        if so, instantly load newly created items into a dictionary with a default value of for review
        
      if accepted, set the value to accepted
      else remove
      
   
   seller can decide the DateTime of Auctioned Item iff Item is accepted
   
//
create a class forReview,


where Class Item will not be auctioned if its status is forReview or Rejected;




*/
