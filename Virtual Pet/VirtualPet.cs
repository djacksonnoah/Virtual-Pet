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
        public int thirst;
        public int boredom;
        public int tiredness;
        public int chooser;

        private int hungerLevel;
        private int thirstLevel;
        private int boredomLevel;
        private int tirednessLevel;



        // properties
        public PET ()
        {

        }

        public PET (int HungerLevel, int ThirstLevel, int BoredomLevel, int TirednessLevel)
        {
            hungerLevel = HungerLevel;
            thirstLevel = ThirstLevel;
            boredomLevel = BoredomLevel;
            tirednessLevel = TirednessLevel;
        }

        public void hungerSassy()
        {

            hunger = hunger + 5;
                
        }

        public int thirstSassy()
        {

            return 8;
        }

        public int boredomSassy()
        {

            return 9;
        }


        public int tirednessSassy()
        {
            return 10;

        }



    }

}
