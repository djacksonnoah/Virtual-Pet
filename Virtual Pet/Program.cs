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
            PET Sassy = new PET(50, 50, 50, 50, 50);
            //VirtualPet virtualPet = new VirtualPet ();

            Console.WriteLine("Sassy the Dog");
            Console.WriteLine("Sassy is a virtual Pet.  Sassy needs to be fed, watered, played with, and put to sleep.");
            Console.WriteLine("Positive numbers mean she is sad because , for example, she needs to eat.");
            Console.WriteLine("Negative numbers mean she is happy.  Please try to make Sassy happy.");
            for (int row = 0; row < 5; row++)
            {
                for (int space = 0; space < 5 - row - 1; space++)
                {
                    Console.Write(" ");
                }

                for (int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Hit any key to play Sassy the Dog.");
            Console.ReadKey();


            Console.WriteLine("Hunger:  {0}", Sassy.hunger = 20);
            Console.WriteLine("Thirst: {0}", Sassy.thirst = 15);
            Console.WriteLine("Boredom: {0}", Sassy.boredom = 10);
            Console.WriteLine("Tiredness: {0}", Sassy.tiredness = 50);
            Console.WriteLine("Hit any key to continue.");
            Console.ReadKey();

            while (true)
            {

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Feed Sassy;");
                Console.WriteLine("2) Water Sassy");
                Console.WriteLine("3) Play with Sassy");
                Console.WriteLine("4) Put Sassy to sleep");
                Console.WriteLine("5) Do nothing");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)

                {
                    Sassy.hungerSassy();


                }

                else if (choice == 2)

                {

                    Sassy.thirstSassy();
                }

                else if (choice == 3)

                {

                    Sassy.boredomSassy();

                }

                else if (choice == 4)

                {
                    Sassy.tirednessSassy();
                }
                else if (choice == 5)

                {
                    Console.WriteLine("Woof, Woof!  Thanks for playing.");
                    Console.ReadKey();
                    break;
                }

                else

                {

                    Console.WriteLine("Please enter a number between 1-4");

                }


                Console.WriteLine("Sassy has changed.  Now her conditions are as follows:");
                Console.WriteLine("Hunger:  {0}", Sassy.hunger);
                Console.WriteLine("Thirst: {0}", Sassy.thirst);
                Console.WriteLine("Boredom: {0}", Sassy.boredom);
                Console.WriteLine("Tiredness: {0}", Sassy.tiredness);
                Console.WriteLine("Hit any key to continue.");
                Console.WriteLine("  ");
                Console.ReadKey();
                Console.WriteLine("What do you want to do?  Hit 1 to continue, 2 to stop.");
                int secondChoice = Convert.ToInt32(Console.ReadLine());

                if (secondChoice == 1)

                {
                    Sassy.Tick();


                }

                else if (secondChoice == 2)

                {
                    Console.WriteLine("Woof, Woof!  Thanks for playing.");
                    Console.ReadKey();
                    break;
                }
                else

                {

                    Console.WriteLine("Please enter 1 or 2.");

                }



            }
        }
    }

}