using FarmAnimals.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAnimals
{
    public class Circumstances
    {
        public Weather Weather { get; set; }
        public Atmosphere Atmosphere { get; set; }
        public DayTime DayTime { get; set; }
        public Season Season { get; set; }

    }
}
