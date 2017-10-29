using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Uus_võimalus_pakkumiseks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");
            Console.WriteLine();

            int SuvalineNumber = new Random().Next(1, 101);
            int minuValik;

            Boolean õigeValik = false;

            void numbriMäng()
            {
                while (õigeValik != true)
                {

                    Console.Write("Sinu Valik: ");


                    var userInput = Console.ReadLine();

                    if (validateInput(userInput))
                    {
                        Console.WriteLine(Vastus());
                    }
                    else
                    {
                        Console.WriteLine("Number ei jää 1 - 100 vahele. Proovi uuesti.");
                    }
                }
            }

            numbriMäng();

            Boolean validateInput(String userInput)
            {

                if (int.TryParse(userInput, out minuValik))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            String Vastus()
            {
                if (minuValik == SuvalineNumber)
                {
                    õigeValik = true;
                    return $"Arvasid numbri ära. \n";
                }
                else
                {
                    if (minuValik < SuvalineNumber)
                    {
                        return $"Teie valik on väiksem arvuti numbrist. Proovi uuesti. \n";
                    }
                    else
                    {
                        return $"Teie valik on suurem arvuti numbrist. Proovi uuesti. \n";
                    }
                }
            }
            Console.ReadLine();
        }
    }
}