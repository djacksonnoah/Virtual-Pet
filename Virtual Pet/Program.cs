using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace VirtualPet
{
    class Program
    {

        static void Main(string[] args)
        {
            VirtualPet myPet = newVirtualPet();

            Console.WriteLine("Sassy the Dog");

            Console.WriteLine("Hunger - ");
            Console.WriteLine("Thirst - ");
            Console.WriteLine("Boredom - ");
            Console.WriteLine("Tiredness - ");

            while (true) ;
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Feed Sassy");
                Console.WriteLine("2) Water Sassy");
                Console.WriteLine("3) Play with Sassy");
                Console.WriteLine("4) Put Sassy to sleep");
                Console.WriteLine("5) Do nothing");

                myPet.Selection = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}