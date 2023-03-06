using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction
{
    public abstract class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Address { get; set; }
        public string Contact{ get; set; }

        public User(string name, DateTime birthDate, string address, string contact) 
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Address = address; 
            this.Contact = contact;
        }

    }
}
