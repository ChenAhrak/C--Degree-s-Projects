using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4
{
    class Costumers
    {
        string id;
        string fName;
        string lName;
        string phone;
        string address;

        public Costumers(string id, string fName, string lName, string phone, string address)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.phone = phone;
            this.address = address;
        }

        public string ID
        {  
            get => id;
            set => id = value;
        }
        public string FNAME
        {  
            get => fName;
            set => fName = value;
        }
        public string LNAME
        {  
            get => lName;
            set => lName = value;
        }
        public string PHONE
        {  
            get => phone;
            set => phone = value;
        }
        public string ADDRESS
        {  
            get => address;
            set => address = value;
        }

        public string toString()
        {
            return($"id: {id} \tfirst name: {fName}\tlast name: {lName}\tphone: {phone}\taddress: {address}\n");
        }
    }
}
