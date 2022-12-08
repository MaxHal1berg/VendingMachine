using System;
using System.Diagnostics.SymbolStore;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using VendingMachine;

internal class Program
{
    public static void Main(string[] args)
    {
        //Välkomstmeddelanden
        Console.WriteLine("Välkommen till Vending Machine V1.1.0");
        Console.WriteLine("Denna maskinen har ett utskänkningstillstånd utfärdat av Göteborgs Stad!");
        
        //Bool för att kunna stänga av vending machine:en
        bool loop = true;
        
        //Här har jag gjort det möjligt att kunna hitta mina olika interfaces
        Drinks drinks = new Drinks();
        Clothes clothes = new Clothes();
        Food food = new Food();
        
        //Här sker allting i min kod
        while (loop)
        {
            //Menyn som visar alla produkter i min vending machine
            Console.WriteLine("Vilken vara vill du ha? Välj ett nummer mellan 1-9");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Du har flera val att kunna beställa!");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Du kan även välja att dricka dessa drycker direkt!");
            Console.WriteLine("Från 1-3: 1: Öl! 2: Vin! 3: Sprit!");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Du kan välja att ta på dig dessa plaggen!");
            Console.WriteLine("Från 4-6: 4: Byxor! 5: Skor! 6: Skjorta! ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Du kan välja att äta maten direkt eller spara den till senare");
            Console.WriteLine("Från 7-9: 7: Pizza! 8: Burgare! 9: Thaimat!");
            Console.WriteLine("------------------------------------------------------------------------");

            // deklarerar en int som heter val för att kunna styra min vending machine
            int val =  Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1: 
                    //öl-fallet där man kan dricka sin öl eller inte beroende på val
                    Console.WriteLine("Din öl har blivit levererad! Vill du dricka ölen? Tryck Y om du vill dricka den, N om du ej vill dricka den");
                    //deklarerar ölsvar för att kunna göra ett val om vad man vill göra med ölen, har även .ToUpper() för att kunna göra programmet mer användarvänligt.
                    string ölSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (ölSvar)
                    {
                        case "Y":
                            //här använder man drunkenbeer-metoden för att kunna skriva ut metodens innehåll i konsolen.
                            drinks.drunkenBeer();
                            break;
                        case "N":
                            drinks.drinkBeer();
                            break;
                    }
                break;
            case 2:
                    Console.WriteLine("Ditt vin har levererats! Vill du dricka vinet? Tryck Y om du vill dricka den, N om du ej vill dricka det");
                    string vinSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (vinSvar)
                    {
                        case "Y":
                            drinks.drunkenWine();
                            break;
                        case "N":
                            drinks.drinkWine();
                            break;
                    }
                break;
            case 3:
                    Console.WriteLine("Din sprit har levererats! Vill du dricka spriten? Tryck Y om du vill dricka den, N om du ej vill dricka den");
                    string spritSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (spritSvar)
                    {
                        case "Y":
                            drinks.drinksPirits();
                            break;
                        case "N":
                            drinks.drunkensPirits();
                            break;
                    }
                    break;
            case 4:
                    Console.WriteLine("Dina byxor har levererats! Vill du ta på dig dom? Tryck Y om du vill det, N om du ej vill det");
                    string byxorSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (byxorSvar)
                    {
                        case "Y":
                            clothes.wearPants();
                            break;
                        case "N":
                            clothes.orderPants();
                            break;
                    }
                    break;
            case 5:
                    Console.WriteLine("Dina skor har levererats! Vill du ta på dig dom? Tryck Y om du det, N om du ej vill det");
                    string skorSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (skorSvar)
                    {
                        case "Y":
                            clothes.orderShoes();
                            break;
                        case "N":
                            clothes.wearShoes();
                            break;
                    }
                    break;
            case 6:
                    Console.WriteLine("Dina skor har levererats! Vill du ta på dig dom? Tryck Y om du vill det, N om du ej vill det");
                    string skjortSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (skjortSvar)
                    {
                        case "Y":
                            clothes.orderShirt();
                            break;
                        case "N":
                            clothes.wearShirt();
                            break;
                    }
                    break;
            case 7:    
                    Console.WriteLine("Din pizza har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string pizzaSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (pizzaSvar)
                    {
                        case "Y":
                            food.orderPizza();
                            break;
                        case "N":
                            food.eatPizza();
                            break;
                    }
                    break;
            case 8:
                    Console.WriteLine("Din burgare har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string burgarSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (burgarSvar)
                    {
                        case "Y":
                            food.orderBurger();
                            break;
                        case "N":
                            food.eatBurger();
                            break;
                    }
                    break;
            case 9:
                    Console.WriteLine("Din thaimat har levererats! Vill du äta den? Tryck Y om du vill det, N om du ej vill det");
                    string thaiSvar = Console.ReadLine().ToUpper();
                    Console.Clear();
                    switch (thaiSvar)
                    {
                        case "Y":
                            food.orderThai();
                            break;
                        case "N":
                            food.eatThai();
                            break;
                    }
                    break;
        }
            //Här får man valet att antingen stänga loopen eller fortsätta beställa varor
            Console.WriteLine("Vill du fortsätta med att beställa varor? Vill du fortsätta så trycker du på Y, vill du inte fortsätta så trycker du på N");
            //Här deklarerar jag stringen svar för att man ska kunna hämta ett svar där man gör ett val om att fortsätta loopen eller ej.
            string svar = Console.ReadLine().ToUpper();
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