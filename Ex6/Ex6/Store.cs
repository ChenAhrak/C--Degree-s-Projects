using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
     abstract class Store: IStore
    {
        int SerialNumber;
        public string Name;
        double Earnings;
        protected Item[] Products=new Item[10];
        protected Transaction[] transactions=new Transaction[20];

        protected Store(int serialNumber, string name, double earnings)
        {
            SerialNumber = serialNumber;
            Name = name;
            Earnings = earnings;
           
        }

        
        virtual public void PerformTransaction(Item item1, string name)
        {
            

        }
        public void Sell(Item item1, string string_name)
        {
            Earnings += item1.Price;
            Transaction trans = new Transaction(string_name, item1.Price, item1);
            for(int i=0;i<transactions.Length;i++)
            {
                if (transactions[i] == null)
                {
                    transactions[i] = trans;
                    break;
                }
            }

        }
        public void AddProduct() // exceptions
        {
            string item_name;
            double item_price;
            Console.WriteLine("Enter Item Name:");
            item_name = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            item_price = double.Parse(Console.ReadLine());
            Item item = new Item(item_name, item_price);
            
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i] == null)
                {
                    Products[i] = item;
                    break;
                }
            } 
        }
        public void ResetStore()
        {

        }
        abstract public void ShowInfo();

    }
}
