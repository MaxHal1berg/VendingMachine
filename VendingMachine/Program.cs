using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        bool loop = true;

        while (loop)
        {
        Console.WriteLine("Vilken vara vill du ha? Välj ett nummer mellan 1-9");

        int val =  Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1: 
                Console.WriteLine("hello");
                break;
            case 2: 
                Console.WriteLine("xd");
                break;
            case 3:
                Console.WriteLine("dx");
                break;
            case 4:
                Console.WriteLine(":V");
                break;
            case 5:
                Console.WriteLine("lmao");
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
                Console.Write("Tack för din medverkan! ");
            }
        }
    }
}