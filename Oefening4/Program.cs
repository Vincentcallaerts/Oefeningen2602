using System;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Over welk jaar wil je iets weten: ");
            getal = Convert.ToInt32(Console.ReadLine());
            switch (getal)
            {
                case 1302: Console.WriteLine("Guldensporenslag"); break;
                case 1492: Console.WriteLine("Columbus ontdekt Amerika"); break;
                case 1830: Console.WriteLine("Belgische Revolutie"); break;
                case 1914: Console.WriteLine("Start Wo 1"); break;
                case 1918: Console.WriteLine("Einde Wo 1"); break;
                case 1939: Console.WriteLine("Start Wo 2"); break;
                case 1945: Console.WriteLine("Eide Wo 2"); break;
                case 2001: Console.WriteLine("9/11"); break;
                case 2020: Console.WriteLine("Ook hier niks interessant gebeurt"); break;
                
                default: Console.WriteLine("Oei dat was geen interessant jaar"); break;
            }
            Console.ReadLine();

        }
    }
}
