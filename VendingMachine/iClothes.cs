using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface iClothes
    {
        public void orderPants();
        public void wearPants();
        public void orderShoes();
        public void wearShoes();
        public void orderShirt();
        public void wearShirt();
    }

    public class Clothes : iClothes
    {
        public void orderPants()
        {
            Console.WriteLine("Du har köpt byxor");
        }

        public void wearPants()
        {
            Console.WriteLine("Du har tagit på dig byxor!");
        }

        public void orderShoes()
        {
            Console.WriteLine("Du har köpt skor!");
        }

        public void wearShoes()
        {
            Console.WriteLine("Du har tagit på dig dina skor!");
        }

        public void orderShirt()
        {
            Console.WriteLine("Du har beställt en skjorta!");
        }

        public void wearShirt()
        {
            Console.WriteLine("Du har tagit på dig skjortan!");
        }
    }
}
