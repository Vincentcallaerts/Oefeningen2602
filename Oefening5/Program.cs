using System;


namespace Oefening5
{
    class Program
    {
        static void Main(string[] args)
        {
            Char letter;
            Console.Write("Geef een letter in: ");
            letter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (letter)
            {
                case 'a': Console.WriteLine("Dat is een klinker"); break;
                case 'e': Console.WriteLine("Dat is een klinker"); break;
                case 'i': Console.WriteLine("Dat is een klinker"); break;
                case 'o': Console.WriteLine("Dat is een klinker"); break;
                case 'u': Console.WriteLine("Dat is een klinker"); break;
                case 'y': Console.WriteLine("Wordt als beide gebruikt"); break;
                

                default: Console.WriteLine("Dat is een medeklinker"); break;
            }

            Console.ReadLine();

        }
    }
}
