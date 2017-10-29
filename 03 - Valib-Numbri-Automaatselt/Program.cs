using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Valib_Numbri_Automaatselt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");
            Console.WriteLine();

            Console.Write("Sinu Valik: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int SuvalineNumber = new Random().Next(1, 101);

            if (number > SuvalineNumber)
            {
                Console.WriteLine("Teie valitud number on suurem minu numbrist.");
            }

            if (number < SuvalineNumber)
            {
                Console.WriteLine("Teie valitud number on väiksem minu numbrist.");
            }

            if (number == SuvalineNumber)
            {

                Console.WriteLine("Arvasid numbri ära.");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
