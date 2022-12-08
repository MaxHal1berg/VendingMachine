using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface iDrinks
    {
        void drinkBeer();
        void drunkenBeer();
        void drinkWine();
        void drunkenWine();
        public void drinksPirits();
        public void drunkensPirits();
    }

    public class Drinks : iDrinks
    {
        public void drinkBeer()
        {
            
            Console.WriteLine("Du har köpt en öl!");
        }

        public void drunkenBeer()
        {
            Console.WriteLine("Din öl är uppdrucken!");
        }

        public void drinkWine()
        {
            Console.WriteLine("Du har köpt vin!");
        }

        public void drunkenWine()
        {
            Console.WriteLine("Du har druckit vinet!");
        }

        public void drinksPirits()
        {
            Console.WriteLine("Du har köpt sprit!");
        }
        public void drunkensPirits()
        {
            Console.WriteLine("Du har druckit spriten!");
        }


    }
}
