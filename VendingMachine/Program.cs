using System;
using System.Diagnostics.SymbolStore;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using VendingMachine;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Vending Machine V1.1.0");
        Console.WriteLine("Denna maskinen har ett utskänkningstillstånd utfärdat av Göteborgs Stad!");

        bool loop = true;

        while (loop)
        {
        Console.WriteLine("Vilken vara vill du ha? Välj ett nummer mellan 1-9");

        int val =  Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1: 
                Drinks beer = new Drinks();
                    Console.WriteLine("Din öl har blivit levererad! Vill du dricka ölen? Tryck Y om du vill dricka den, N om du ej vill dricka den");
                    string ölSvar = Console.ReadLine();
                    Console.Clear();
                    switch (ölSvar)
                    {
                        case "Y":
                            beer.drunkenBeer();
                            break;
                        case "N":
                            beer.drinkBeer();
                            break;
                    }
                break;
            case 2:
                    Drinks wine = new Drinks();
                    Console.WriteLine("Ditt vin har levererats! Vill du dricka vinet? Tryck Y om du vill dricka den, N om du ej vill dricka det");
                    string vinSvar = Console.ReadLine();
                    Console.Clear();
                    switch (vinSvar)
                    {
                        case "Y":
                            wine.drunkenWine();
                            break;
                        case "N":
                            wine.drinkWine();
                            break;
                    }
                break;
            case 3:
                    Drinks spirits = new Drinks();
                    Console.WriteLine("Din sprit har levererats! Vill du dricka spriten? Tryck Y om du vill dricka den, N om du ej vill dricka den");
                    string spritSvar = Console.ReadLine();
                    Console.Clear();
                    switch (spritSvar)
                    {
                        case "Y":
                            spirits.drinksPirits();
                            break;
                        case "N":
                            spirits.drunkensPirits();
                            break;
                    }
                    break;
            case 4:
                    Clothes pants = new Clothes();
                    Console.WriteLine("Dina byxor har levererats! Vill du ta på dig dom? Tryck Y om du vill det, N om du ej vill det");
                    string byxorSvar = Console.ReadLine();
                    Console.Clear();
                    switch (byxorSvar)
                    {
                        case "Y":
                            pants.wearPants();
                            break;
                        case "N":
                            pants.orderPants();
                            break;
                    }
                    break;
            case 5:
                    Clothes shoes = new Clothes();
                    Console.WriteLine("Dina skor har levererats! Vill du ta på dig dom? Tryck Y om du det, N om du ej vill det");
                    string skorSvar = Console.ReadLine();
                    Console.Clear();
                    switch (skorSvar)
                    {
                        case "Y":
                            shoes.orderShoes();
                            break;
                        case "N":
                            shoes.wearShoes();
                            break;
                    }
                    break;
            case 6:
                    Clothes shirt = new Clothes();
                    Console.WriteLine("Dina skor har levererats! Vill du ta på dig dom? Tryck Y om du vill det, N om du ej vill det");
                    string skjortSvar = Console.ReadLine();
                    Console.Clear();
                    switch (skjortSvar)
                    {
                        case "Y":
                            shirt.orderShirt();
                            break;
                        case "N":
                            shirt.wearShirt();
                            break;
                    }
                    break;
            case 7:
                    Food pizza = new Food();
                    Console.WriteLine("Din pizza har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string pizzaSvar = Console.ReadLine();
                    Console.Clear();
                    switch (pizzaSvar)
                    {
                        case "Y":
                            pizza.orderPizza();
                            break;
                        case "N":
                            pizza.eatPizza();
                            break;
                    }
                    break;
            case 8:
                    Food burgare = new Food();
                    Console.WriteLine("Din burgare har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string burgarSvar = Console.ReadLine();
                    Console.Clear();
                    switch (burgarSvar)
                    {
                        case "Y":
                            burgare.orderBurger();
                            break;
                        case "N":
                            burgare.eatBurger();
                            break;
                    }
                    break;
            case 9:
                    Food thai = new Food();
                    Console.WriteLine("Din thaimat har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string thaiSvar = Console.ReadLine();
                    Console.Clear();
                    switch (thaiSvar)
                    {
                        case "Y":
                            thai.orderThai();
                            break;
                        case "N":
                            thai.eatThai();
                            break;
                    }
                    break;
        }
            Console.WriteLine("Vill du fortsätta med att beställa varor? Vill du fortsätta så trycker du på Y, vill du inte fortsätta så trycker du på N");
            string svar = Console.ReadLine();
            if (svar == "Y")
            {
                loop = true;
            }
            else if (svar == "N")
            {
                loop = false;
                Console.Write("Tack för dina beställningar!");
            }
        }
    }
}