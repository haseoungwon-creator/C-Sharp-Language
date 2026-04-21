using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Barracks
    {

        private int count =0;
        private Soldier[] soldiers = new Soldier[5];
        public void Create(int select int i)
        {



            switch (select)
            {
                case 1:
                    soldiers = new Knight();
                    break;
                case 2:
                    soldiers = new Archer();
                    break;
                case 3:
                    soldiers = new Guard();
                    break;
            }
          
        }

        public void Battle()
        {
            foreach(Soldier element in soldiers)
            {
                element.Attack();
            }
        }
    }
}
