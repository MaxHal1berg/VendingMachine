using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface iDrinks
    {
        //Deklarerar metoder här i interface för att de ska kunna användas
        void drinkBeer();
        void drunkenBeer();
        void drinkWine();
        void drunkenWine();
        public void drinksPirits();
        public void drunkensPirits();
    }

    public class Drinks : iDrinks
    {
        //Här är alla olika dryckklasser

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
