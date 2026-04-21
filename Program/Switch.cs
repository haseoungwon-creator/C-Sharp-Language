using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Switch : ISelectable
    {
        int Count = 0;
        public void Select()
        {
            switch (Count)
            {
                case 0:
                    Console.WriteLine("examine the Switch. . .");
                    break;
                case 1:
                    Console.WriteLine("어 버튼이 이상한데");
                    break;
                case 2:
                    Console.WriteLine("버튼이 고장났다");
                    break;
            }
            Count++;
        }

    }
}

