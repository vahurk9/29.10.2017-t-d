using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Suurem_väiksem_võrdeline
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
            int SuvalineNumber = 73;


            if (number > SuvalineNumber)
            {
                Console.WriteLine("Teie valitud number on suurem arvuti numbrist.");
            }

            if (number < SuvalineNumber)
            {
                Console.WriteLine("Teie valitud number on väiksem arvuti numbrist.");

            }

            if (number == SuvalineNumber)
            {

                Console.WriteLine("Arvasid Numbri ära.");
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
