using System;


namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            Console.Write("De hoeveelste maand is het: ");
            getal = Convert.ToInt32(Console.ReadLine());
            switch (getal)
            {
                case 1: Console.WriteLine("Januarie"); break;
                case 2: Console.WriteLine("Februarie"); break;
                case 3: Console.WriteLine("Maart"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("Mei"); break;
                case 6: Console.WriteLine("Juni"); break;
                case 7: Console.WriteLine("Juli"); break;
                case 8: Console.WriteLine("Augustus"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Oei dat was geen juiste input"); break;
            }
            Console.ReadLine();
        }
    }
}
