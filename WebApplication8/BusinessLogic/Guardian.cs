using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.BusinessLogic
{
    public class Guardian
    {
        private int ID;
        private string fName, lName, contact, email, address;
        bool isActive;

        public Guardian(int iD, string fName, string lName, string contact, string email, string address, bool isActive)
        {
            ID = iD;
            this.fName = fName;
            this.lName = lName;
            this.contact = contact;
            this.email = email;
            this.address = address;
            this.isActive = isActive;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
    }
}