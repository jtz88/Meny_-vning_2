using System;


namespace Meny_Övning_2
{
    public class MainMenu
    {
        public int DisplayMenu()
        {
            //Metod för att generera huvudmeny och returnera användarval

            System.Console.WriteLine("\nVälkommen till huvudmenyn. Välj vilken funktion du vill testa!\n");
            System.Console.WriteLine("1.) Ungdom eller pensionär");
            System.Console.WriteLine("2.) Sällskap");
            System.Console.WriteLine("3.) Upprepa tio gånger");
            System.Console.WriteLine("4.) Det tredje ordet");
            System.Console.WriteLine("5.) Avsluta programmet");
            System.Console.Write("\nMata in dit val: ");

            var result = Console.ReadLine();
            return Convert.ToInt32(result);

        }

        public void PriceForParty()
        {
            // Metod för att räkna ut antal köpta biljetter samt total pris

            Console.WriteLine("\nHur många är ni i ert sällskap?");
            var result = Convert.ToInt32(Console.ReadLine());

            var total = 0;

            for (int i = 0; i < result; i++)
            {
                /* generera consolewriteline x antal ggr baserat på antal i sällskap

                deklarera variabel utanför If - sats som adderar += totalt pris

                Person 1 ålder: */

                Console.WriteLine($"Ålder på person {i+1}: ");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age < 20)
                {
                    total += 80;
                }
                else if (age > 64)
                {
                    total += 90;
                }
                else
                {
                    total += 120;
                }
            }
            Console.WriteLine($"Erat sällskap består av {result} personer och kostnaden för hela sällskapet blir: {total}");
        }

        public void SplitAString()
        {
            // Metod för splitta användarens inmatning och skriva ut tredje index

            Console.WriteLine("\nSkriv en mening med minst 3 ord, det tredje ordet kommer att skrivas ut: ");
            string input = Console.ReadLine();

            string[] splitResult = input.Split(' ');
            Console.WriteLine($"Det tredje ordet är: {splitResult[2]}");


        }

        public void RepeatTenTimes()
        {
            // Metod för att upprepa användarens inamtning 10 ggr

            Console.WriteLine("Skriv en godtycklig text, denna kommer att upprepas tio gånger\n");
            string text = Console.ReadLine();

            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i}. {text} ");
            }
        }

        public void YoungOrOld()
        {
            // Metod för att avgöra användarens ålder och skriva ut korrekt biljettpris

            Console.WriteLine("Hur gammal är du?");

            var result = Console.ReadLine();
            int age = Convert.ToInt32(result);

            if (age < 20 )
            {
                Console.WriteLine("\nUngdomspris: 80kr\n");
            }
            else if (age > 64)
            {
                Console.WriteLine("\nPensionärspris: 90kr\n");
            }
            else
            {
                Console.WriteLine("\nStandardpris: 120kr\n");
            }

        }
    }
}