using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    public interface IStore
    {
        public void Sell(Item item1, string string_name); 
        public void AddProduct(); 
        public void ResetStore();
    }
}
