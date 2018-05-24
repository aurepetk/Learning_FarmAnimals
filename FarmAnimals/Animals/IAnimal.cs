using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    interface IAnimal
    {
        void Eat(string food);
        void Usage(Circumstances circumstances);
    }
}
