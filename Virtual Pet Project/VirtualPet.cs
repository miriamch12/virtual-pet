using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Virtual_Pet_Project
{
    public class VirtualPet
    {
        //FIELDS
        private string fullName;
        private int happiness;
        private int hunger;
        private int energy;

        //CONSTRUCTOR
        public VirtualPet(string newFullname, int newHappiness, int newHunger, int newEnergy)
        {
            //BODY OF CONSTRUCTOR
            fullName = newFullname;
            happiness = newHappiness;
            hunger = newHunger;
            energy = newEnergy;
        }


        //SETTING THE PARAMETERS TO FIELDS

        //NAME
        public void setFullname(string newFullname)
        {
            fullName = newFullname;
        }
        public string getFullname()
        {
            return fullName;
        }

        //HAPPINESS
        public void addHappiness(int newHappiness)
        {
            happiness = happiness + newHappiness;
        }
        public int getHappiness()
        {
            return happiness;       
        }
        public void setHappiness(int newHappiness)
        {
            happiness = newHappiness;
        }

        //HUNGER
        public void addHunger(int newHunger)
        {
            hunger = hunger + newHunger;
        }
        public int getHunger()
        {
            return hunger;
        }
        public void setHunger(int newHunger)
        {
            hunger = newHunger;
        }

        //ENERGY
        public void addEnergy(int newEnergy)
        {
            energy = energy + newEnergy;
        }
        public int getEnergy()
        {
            return energy;
        }
        public void setEnergy(int newEnergy)
        {
            energy = newEnergy;
        }
       
        
        //TICK METHOD
        public void Tick()
        {
            setHappiness(0);
            setHunger(0);
            setEnergy(0);                         
         }


        //CREATE IMAGE
        public void Image()
        {
            Console.WriteLine("                      ___");
            Console.WriteLine("                    // __`\\  o o ~     ******");
            Console.WriteLine("                   ll ( .) l_) ) `  ****MEOW*");
            Console.WriteLine("                   __\\ \\__/   /        ******");
            Console.WriteLine(" _________________/_/________/^^\n");
        }
        

        //PRINT OUT VALUES
        public void print()
        {

            StringBuilder pet = new StringBuilder();
            pet.Append(fullName);
            pet.Append("\nHappiness: " + happiness);
            pet.Append("\nHunger: " + hunger);
            pet.Append("\nEnergy: " + energy);
            Console.WriteLine(pet.ToString());           
        }

        //LIST OPTIONS
        public void options()
        {
            List<string> snail = new List<string>();
            snail.Add("\n1. Feed Gary Snail Snacks");
            snail.Add("2. Let Gary play with the red bouncy ball");
            snail.Add("3. Take Gary out for a walk");
            foreach (string s in snail)
            {
                Console.WriteLine(s);
            }
        }

        
    }
}
