using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Character
    {
        private List<Weapon> weapons = new List<Weapon>();
        public int currentCount = 0;
        
        public void Acquire(Weapon weapon)
        {
            weapons.Add(weapon);
            Console.WriteLine($"{weapon.GetType().Name} acquire");
            Console.Write("Weapon List :\t");
           
        }

        public void Attack()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    weapons[currentCount].Attack();
                }
            }
            
        }

        public void Swap()
        {

            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    currentCount++;
                    Console.WriteLine($"Swap : {weapons[currentCount].GetType().Name}");

                    if(weapons.Count <= currentCount)
                    {
                        currentCount = 0;
                    }
                }
            }
        }
       
    }
}
