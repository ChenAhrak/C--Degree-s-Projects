using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class Customers
    {
        string id;
        string fName;
        string lName;
        string phone;
        string address;

        public Customers(string id,string fName,string lName,string phone,string address)
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

         public void toString()
        {
            Console.WriteLine($"Id: {id}\tFname: {fName}\tLast Name: {lName}\tPhone: {phone}\tAddress: {address}");
        }
    }
}