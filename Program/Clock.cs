using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Clock : ISelectable
    {
        int Count=0;
        public void Select()
        {
            switch (Count)
            {
                case 0: Console.WriteLine("examine the Clock. . .");
                    break;
                case 1: Console.WriteLine("어 시계가 이상한데");
                    break;
                case 2: Console.WriteLine("시계가 떨어졌다");
                    break;
            }
            Count++;
        }
    }
}
