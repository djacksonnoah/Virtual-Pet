using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class VirtualPet
    {
        // instance variables
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private int selection;
        // properties
        public int Selection()
        {
           
            return selection;
        }


        public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
            }
        }

        public int Thirst
        {
            get
            {
                return thirst;
            }
            set
            {
                if (value < 0)
                    thirst = 1;
                else
                    thirst = value;
            }
        }
        public int Boredom
        {
            get
            {
                return boredom;
            }
            set
            {
                boredom = value;
            }
        }

        public int Tiredness
        {
            get
            {
                return tiredness;
            }
            set
            {
                if (value < 0)
                    tiredness = 1;
                else
                    tiredness = value;
            }

        }

        // methods
        public void DisplayMessage()
        {
            Console.WriteLine("Hunger is ", Hunger);
            Console.WriteLine("Thirst is ", Thirst);
            Console.WriteLine("Boredom is ", Boredom);
            Console.WriteLine("Tiredness is ", Tiredness);
        }
        

    // contructors
    public VirtualPet(int hunger, int thirst, int boredom, int tiredness)
        {
            Hunger = hunger;
            Thirst = thirst;
            Boredom = boredom;
            Tiredness = tiredness;
        }



    }
    
}
