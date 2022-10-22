using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasadaDemo
{
    internal class BrideFasade
    {
        public double WeddingCost = 0;



        public string MakeWedding()
        {
            Restaurant restaurant = new Restaurant();
            Band band = new Band();
            FlowerShop flowershop = new FlowerShop();

            WeddingCost += restaurant.EstimateCost(100);

            WeddingCost += flowershop.EstimateFlowers();

            WeddingCost += band.EstimateCost(5);

            restaurant.BuyIngredients(100);
            flowershop.MakeFlowers();
            band.MakeATry();
            bool DishesReady = restaurant.GetDishes(100);
            if(DishesReady)
            {
                return "Wedding is ready!";
            }
            return "We couldn't prepare your wedding :(";

        }


    }
}
