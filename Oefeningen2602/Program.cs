using System;


namespace Oefeningen2602
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Wat is jouw niveau op een schaal van 1-3: ");
            getal = Convert.ToInt32(Console.ReadLine());
            switch (getal)
            {
                case 1: Console.WriteLine("Je bent Junior");break;
                case 2: Console.WriteLine("Je bent Medior");break;
                case 3: Console.WriteLine("Je bent Senior");break;
                default: Console.WriteLine("Oei dat was geen juiste input");break;
            }
            Console.ReadLine();

        }
    }
}
