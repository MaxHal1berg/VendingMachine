using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface iFood
    {
        public void orderPizza();
        public void eatPizza();
        public void orderBurger();
        public void eatBurger();
        public void orderThai();
        public void eatThai();
    }

    public class Food : iFood 
    {
        public void orderPizza()
        {
            Console.WriteLine("Du har beställt Pizza");
        }
        public void eatPizza()
        {
            Console.WriteLine("Du har ätit Pizzan");
        }
        public void orderBurger()
        {
            Console.WriteLine("Du har beställt Burgare!");
        }
        public void eatBurger()
        {
            Console.WriteLine("Du har ätit Burgare!");
        }
        public void orderThai()
        {
            Console.WriteLine("Du har beställt Thaimat");
        }
        public void eatThai()
        {
            Console.WriteLine("Du har ätit Thaimaten!");
        }
    }
}
