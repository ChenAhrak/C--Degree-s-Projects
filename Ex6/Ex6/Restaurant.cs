using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class Restaurant: Store,IFood
    {
        public enum RestaurantTypes { meat,cafe,italian,burgers};
        protected string[] Menu;
        protected string[] Specials;
        protected RestaurantTypes RestaurantType;

        public Restaurant(string[] menu, string[] specials, RestaurantTypes restaurantType,int serialNumber, string name, double earnings):base(serialNumber,  name,  earnings)
        {
            Menu = menu;
            Specials = specials;
            RestaurantType = restaurantType;
        }

        public void AddSpecial()
        {

        }

        public void ClearSpecials()
        {

        }

        public void ClearMenu()
        {

        }

       override public void ShowInfo()
        {
            //Console.Writeline($"Serial NUmber:{base.} Name: {Name} Earnings: {Earnings} ");
            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"Products: {Products}");
            //}
            //foreach (var item in this.transactions)
            //{
            //    Console.WriteLine($" Transaction: {this.Products} ");

            //}
        }

        override public void PerformTransaction(Item item1, string name)
        {


        }
        public void ShowMenu()
        {

        }
        public void ShowSpecials()
        {

        }
        public void ShowChefInfo()
        {

        }
    }
}
