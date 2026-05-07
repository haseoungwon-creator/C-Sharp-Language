using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Grenade : Weapon
    {
        public int Damage = 25;
        public int Range = 5;

        public override void Attack()
        {
            Console.WriteLine($"Damage : {Damage}\t");
        }
    }
}
