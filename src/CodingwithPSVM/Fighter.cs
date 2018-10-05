using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingwithPSVM
{
    public abstract class Fighter
    {
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public abstract void Heal(int amount);
    }
}
