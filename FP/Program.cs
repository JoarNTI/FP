using System;

namespace FP
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;

            //Första Frågan
            Console.WriteLine("Vilka färger har Sveriges flagga?");
            Console.WriteLine("A: Blå o Gul");
            Console.WriteLine("B: Röd o Gul");
            Console.WriteLine("C: Grön o Röd");
            Console.WriteLine("D: Blå o Grön");


            string a = Console.ReadLine();
            if (a == "A")
            {
                Console.WriteLine("Rätt Svar! +10 Poäng");
                points += 10;
            }
            else if (a == "B" || a == "C" || a == "D")
            {
                Console.WriteLine("Fel Svar! -5 Poäng");
                points -= 5;
            }
            else
            {
                Console.WriteLine("Välj mellan Svaren A, B, C eller D");
            }

            //Andra Frågan
            Console.WriteLine("Vem är Sveriges Kung?");
            Console.WriteLine("A: Gustav II Adolf");
            Console.WriteLine("B: Bollibompadraken");
            Console.WriteLine("C: Karl XIV Gustav");
            Console.WriteLine("D: Carl XVI Gustaf");


            string b = Console.ReadLine();
            if (b == "D")
            {
                Console.WriteLine("Rätt Svar! +10 Poäng");
                points += 10;
            }
            else if (a == "B" || a == "C" || a == "A")
            {
                Console.WriteLine("Fel Svar! -5 Poäng");
                points -= 5;
            }
            else
            {
                Console.WriteLine("Välj mellan Svaren A, B, C eller D");
            }

            //Tredje Frågan
            Console.WriteLine("Hur stor är Sverige i km2?");
            Console.WriteLine("A: 350 394");
            Console.WriteLine("B: 367 649");
            Console.WriteLine("C: 450 295");
            Console.WriteLine("D: 441 836");


            string c = Console.ReadLine();
            if (c == "C")
            {
                Console.WriteLine("Rätt Svar! +10 Poäng");
                points += 10;
            }
            else if (a == "B" || a == "A" || a == "D")
            {
                Console.WriteLine("Fel Svar! -5 Poäng");
                points -= 5;
            }
            else
            {
                Console.WriteLine("Välj mellan Svaren A, B, C eller D");
            }



            Console.ReadLine();
        }
    }
}
