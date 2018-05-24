using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    class Cat: IAnimal
    {
        public void Eat(string food)
        {
            if (food == "fish")
            {
                Talk();
            }
            else
            {
                Attack();
            }
        }

        public void Usage(Circumstances circumstances)
        {
            switch ((int)circumstances.Weather)
            {
                case 0:
                    Console.WriteLine("Sits near the heat source and doesn't react to your commands at all. NO USAGE.");
                    break;
                case 1:
                    Console.WriteLine("Sits on your lap and warms you with it's fluffiness.");
                    break;
                case 2:
                    Console.WriteLine("Licks your warm face and cools you a little.");
                    break;
                case 3:
                    Console.WriteLine("Lies in the shadow and doesn't pay any attention to you. NO USAGE.");
                    break;
                case 4:
                    Console.WriteLine("Sits with you inside and gives you warmnees and calmness.");
                    break;
                case 5:
                    Console.WriteLine("Sits on your head and gives you shadow.");
                    break;
                case 6:
                    Console.WriteLine("Protects you from storm with it's fluffiness.");
                    break;
            }

        }

        public void Talk()
        {
            Console.WriteLine("Mew mew mew! :)");
        }

        public void Attack()
        {
            Console.WriteLine("Scratches your face :/");
        }
    }
}
