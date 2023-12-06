using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class ClothingStore:Store
    {
        public enum Seasons {summer,fall,winter,spring };
        Seasons Collection;
        public bool isOnSale;
        public double SalePercent;

        public ClothingStore(bool isOnSale, double salePercent, int serialNumber, string name, double earnings) : base(serialNumber, name, earnings)
        {

            Collection = Seasons.summer;
            this.isOnSale = isOnSale;
            SalePercent = salePercent;
        }

        override public void PerformTransaction(Item item1, string name)
        {


        }
        public void ChangeCollection()
        {

        }

        public void InitSale()
        {

        }

        public void EndSale()
        {

        }
        override public void ShowInfo()
        {

        }

        //override public void PerformTransaction(Item item1, string name)
        //{
        //    base.PerformTransaction(item, str);

        //}

    }
}
