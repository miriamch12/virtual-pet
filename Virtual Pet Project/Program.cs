using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Pet_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING OBJECT
            VirtualPet Gary = new VirtualPet("Gary the Snail", 50, 50, 50);

            //CALL IMAGE
            Gary.Image();

            do
            {               
                //CALL VARIABLES
                Gary.print();

                //CALL OPTIONS LIST
                Gary.options();
                
               //INFORM USERS WHAT TO DO
                Console.WriteLine("What would you like to do? Press the corressponding number.\n\n *******BEWARE*******\n\nIf you press a number that does correspond with a task, \nsomething bad will happen!");

               //GET USER'S RESPONSE
                int response = int.Parse(Console.ReadLine());
                
                //IF USER SELECTS 1
                if (response == 1)
                {
                    Gary.addHunger(15);
                    Gary.addEnergy(20);
                    Console.Clear();
                    Console.WriteLine("You've fed Gary\n");
                    Console.WriteLine("Gary's HUNGER and ENERGY has INCREASED\n\n");
                }
                //IF USER SELECTS 2
                else if (response == 2)
                {
                    Gary.addHunger(-5);
                    Gary.addHappiness(30);
                    Gary.addEnergy(-5);
                    Console.Clear();
                    Console.WriteLine("Gary is playing\n");
                    Console.WriteLine("Gary's HAPPINESS has INCREASED,\nbut both his ENERGY and HUNGER has DECREASED\n\n");
                }
                //IF USER SELECTS 3
                else if (response == 3)
                {
                    Gary.addHunger(-5);
                    Gary.addHappiness(15);
                    Console.Clear();
                    Console.WriteLine("You've taken Gary for a walk\n");
                    Console.WriteLine("Gary's HAPPINESS has INCREASED,\nbut his HUNGER has DECREASED");
                }
                //IF USER SELCECTS ANYTHING ELSE
                else
                {
                    Gary.Tick();                    
                    Console.Clear();
                    Console.WriteLine("I TOLD YOU SO...\nNOW LOOK WHAT YOU HAVE DONE\n");
                }


                //SHOWS HOW GARY LOOKS LIKE
                if (Gary.getEnergy() > 25 && Gary.getHappiness() > 25 && Gary.getHunger() >25)
                {
                    Console.WriteLine("\nGary looks like:  :)\n");
                }
                else
                {
                    Console.WriteLine("\nGary looks like   :(\n");
                }

            }
            while (true);

        }
    }
}
