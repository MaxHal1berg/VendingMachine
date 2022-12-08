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
                    Console.WriteLine("Dina byxor har levererats! Vill du ta på dig dom? Tryck Y om du det, N om du ej vill det");
                    string byxorSvar = Console.ReadLine();

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
                Console.WriteLine("wot");
                break;
            case 7:
                Console.WriteLine("f");
                break;
            case 8:
                Console.WriteLine("kekw");
                break;
            case 9:
                Console.WriteLine(":D");
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