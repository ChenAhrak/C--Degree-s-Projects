using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class FastFoodRestaurant: Restaurant
    {
        Item[] PromotionMeals;
        DateTime OilChangeDate;

        public FastFoodRestaurant(Item[] promotionMeals, DateTime oilChangeDate, string[] menu, string[] specials, RestaurantTypes restaurantType, int serialNumber, string name, double earnings)
            :base(menu, specials, restaurantType, serialNumber,name, earnings)
        {
            PromotionMeals = promotionMeals;
            OilChangeDate = oilChangeDate;
        }


        public void AddPromotion()
        {

        }

        public void GetPromotions()
        {

        }
        public void ChangeOil()
        {

        }
        override public void ShowInfo()
        {

        }

        override public void PerformTransaction(Item item1, string name)
        {


        }

    }
}
