using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    internal class Restaurant
    {
        private int ingredients = 0;
        public double EstimateCost(int guest)
        {
            return guest * 100;

        }
        public void BuyIngredients(int guest)
        {
            ingredients = guest;
        }
        public bool GetDishes(int guest)
        {
            if (ingredients >= guest) 
            {
                return true;
            }
            return false;
        }
    }
}
