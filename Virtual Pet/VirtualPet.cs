using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class PET
    {
        // instance variables
        public int hunger { get; set; }
        public int thirst { get; set; }
        public int boredom { get; set; }
        public int tiredness { get; set; }
        // public int addAFew { get; set; }

        // private int HungerLevel;
        // private int thirstLevel;
        // private int boredomLevel;
        // private int tirednessLevel;


        // properties
        public PET()
        {

        }

        public PET(int HungerLevel, int ThirstLevel, int BoredomLevel, int TirednessLevel, int AddAFew)
        {
        }

        public void hungerSassy()
        {

            hunger = hunger - 33;
            thirst = thirst + 10;
            boredom = boredom - 31;
            tiredness = tiredness - 15;

        }

        public void thirstSassy()
        {

            hunger = hunger + 8;
            thirst = thirst - 42;
            boredom = boredom - 35;
            tiredness = tiredness + 15; ;
        }

        public void boredomSassy()
        {

            hunger = hunger + 43;
            thirst = thirst + 50;
            boredom = boredom - 41;
            tiredness = tiredness + 15; ;
        }


        public void tirednessSassy()
        {
            hunger = hunger + 40;
            thirst = thirst + 10;
            boredom = boredom - 31;
            tiredness = tiredness - 45; ;

        }
        public void Tick()
        {

            int AddAFew;
            Random random = new Random();
            AddAFew = random.Next();
            if (AddAFew <= 10 && AddAFew > 0)
            {
                hunger = hunger + AddAFew;
                thirst = thirst + AddAFew;
                boredom = boredom + AddAFew;
                tiredness = tiredness + AddAFew;

                //Console.WriteLine("Sassy has changed.  Now her conditions are as follows:");
                Console.WriteLine("Hunger:  {0}", hunger);
                Console.WriteLine("Thirst: {0}", thirst);
                Console.WriteLine("Boredom: {0}", boredom);
                Console.WriteLine("Tiredness: {0}", tiredness);

            }
            else
            {
                hunger = hunger + 4;
                thirst = thirst + 6;
                boredom = boredom + 7;
                tiredness = tiredness + 9;

                //Console.WriteLine("Sassy has changed.  Now her conditions are as follows:");
                Console.WriteLine("Hunger:  {0}", hunger);
                Console.WriteLine("Thirst: {0}", thirst);
                Console.WriteLine("Boredom: {0}", boredom);
                Console.WriteLine("Tiredness: {0}", tiredness);

            }

        }



    }



}


