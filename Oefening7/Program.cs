using System;


namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {

            int getal;
            Console.Write("Hallo! Ik ben een chatbot! Wat kan ik vandaag voor je doen?");
            getal = Convert.ToInt32(Console.ReadLine().ToLower());
            switch (getal)
            {
                case 1:
                    Console.WriteLine("Ik heb hulp nodig bij mijn programmeerlessen");
                    Console.Write("Oei. Heb je al geprobeerd om het op te zoeken op het internet?");
                    getal = Convert.ToInt32(Console.ReadLine().ToLower());
                    switch (getal)
                    {
                        case 1:
                            Console.WriteLine("Ja, tevergeefs.");
                            Console.Write("Anders moet je het eens aan je medecursisten vragen ?");
                            getal = Convert.ToInt32(Console.ReadLine().ToLower());
                            switch (getal)
                            {
                                case 1: Console.WriteLine("Die weten het antwoord ook niet..."); Console.WriteLine("Probeer het zeker aan je leerkracht te vragen!Die zal zijn best doen om het uit te leggen");break;
                                case 2: Console.WriteLine("Ah ja, misschien weten zij het!\nGraag gedaan"); break;
                                default: Console.WriteLine("Oei dat was geen juiste input"); break;
                            }
                            break;
                        case 2: Console.WriteLine("Oh, slim! Ik zal het even proberen."); Console.WriteLine("Graag gedaan"); break;
                        default: Console.WriteLine("Oei dat was geen juiste input"); break;
                    }; break;
                case 2:
                    Console.WriteLine("Ik verveel me.");
                    Console.Write("Oei, wil je iets doen?");
                    getal = Convert.ToInt32(Console.ReadLine().ToLower());
                    switch (getal)
                    {
                        case 1: Console.WriteLine("Vertel me eens een mopje?"); Console.WriteLine("Hmm, ik ken er niet meteen eentje, sorry");break;
                        case 2: Console.WriteLine("Ik zou graag de oefening afwerken"); Console.WriteLine("Ok, dan laat ik je zeker doorwerken"); break;
                        case 3: Console.WriteLine("Niet per see, tot later!"); Console.WriteLine("Dag!"); break;
                        default: Console.WriteLine("Oei dat was geen juiste input");break;
                    }
                    break;
                case 3: Console.WriteLine("Niets,toch bedankt"); Console.WriteLine("Graag Gedaan"); break;
                default: Console.WriteLine("Oei dat was geen juiste input"); break;

            }
            

            Console.ReadLine();

        }
    }
}
