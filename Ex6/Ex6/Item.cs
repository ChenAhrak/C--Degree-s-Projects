using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    public class Item
    {
        private string name;
        private double price;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Item(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
