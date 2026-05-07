using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Weapon
    {
        public int Damage;
        public int Range;

        public abstract void Attack();
    }
}
