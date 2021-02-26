using System;


namespace Oefening3
{
    class Program
    {
        static void Main(string[] args)
        {
            string maand;
            Console.Write("Welkee maand is het: ");
            maand = Console.ReadLine().ToLower();
            switch (maand)
            {
                case "januarie": Console.WriteLine("1"); break;
                case "februarie": Console.WriteLine("2"); break;
                case "maart": Console.WriteLine("3"); break;
                case "april": Console.WriteLine("4"); break;
                case "mei": Console.WriteLine("5"); break;
                case "juni": Console.WriteLine("6"); break;
                case "juli": Console.WriteLine("7"); break;
                case "augustus": Console.WriteLine("8"); break;
                case "september": Console.WriteLine("9"); break;
                case "october": Console.WriteLine("10"); break;
                case "november": Console.WriteLine("11"); break;
                case "december": Console.WriteLine("12"); break;
                
                default: Console.WriteLine("Oei dat was geen juiste input"); break;
            }
            Console.ReadLine();
        }
    }
}
