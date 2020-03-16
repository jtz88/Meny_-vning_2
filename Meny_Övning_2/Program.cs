using System;

namespace Meny_Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instansiera MainMenu klassen

            MainMenu menu = new MainMenu();

            // Evighetsloop tills userinput är 4

            int userInput = 0;
            do
            {
                switch (userInput)
                {
                    case 1:
                        menu.YoungOrOld();
                        break;
                    case 2:
                        menu.PriceForParty();
                        break;
                    case 3:
                        menu.RepeatTenTimes();
                        break;
                    case 4:
                        menu.SplitAString();
                        break;
                    default:
                        break;
                }

                userInput = menu.DisplayMenu();
            } while (userInput != 5);

        }
    }
}
