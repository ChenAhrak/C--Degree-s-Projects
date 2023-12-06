using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    public class Transaction
    {
        public string Name; // input + item Name 
        public double Price; //  Transaction amount
        public DateTime date;
        Item item1;
        public Transaction(string name, double price,Item item1)
        {
            Name = name + ";" + item1.Name;
            Price = price;
            date=DateTime.Now;
        }
    }
}
