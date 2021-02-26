using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Over welk jaar wil je weten of het een schrikkeljaar is: ");
            getal = Convert.ToInt32(Console.ReadLine());

            if (getal % 4 == 0)
            {
                if (getal % 100 == 0)
                {
                    if (getal % 400 == 0)
                    {
                        Console.WriteLine("Schrikkeljaar");
                    }
                    else
                    {
                        Console.WriteLine("Geen Schrikkeljaar");
                    }
                }
                else
                {
                    Console.WriteLine("Schrikkeljaar");
                }
            }
            else
            {
                Console.WriteLine("Geen Schrikkeljaar");
            }


            Console.ReadLine();


        }
    }
}
