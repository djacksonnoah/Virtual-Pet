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
        public int chooser { get; set; }

        // private int HungerLevel;
        // private int thirstLevel;
        // private int boredomLevel;
        // private int tirednessLevel;

    
        // properties
        public PET ()
        {

        }

        public PET (int HungerLevel, int ThirstLevel, int BoredomLevel, int TirednessLevel)
        {
            hunger = HungerLevel;
            thirst = ThirstLevel;
            boredom = BoredomLevel;
            tiredness = TirednessLevel;
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


        // private int myTimer;
        // private int ProcessTick;


        // myTimer();
        // ProcessTick();

        // private void MyTimer_Tick(...)
        // {
        //    ProcessTick();
        // }

        // private void ProcessTick()
       // {
       //

    }

}
