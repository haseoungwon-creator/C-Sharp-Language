using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


internal class Switch : ISelectable,IActivatable
{
    //int Count = 0;
    //public void Select()
    //{
    //    switch (Count)
    //    {
    //        case 0:
    //            Console.WriteLine("examine the Switch. . .");
    //            break;
    //        case 1:
    //            Console.WriteLine("어 버튼이 이상한데");
    //            break;
    //        case 2:
    //            Console.WriteLine("버튼이 고장났다");
    //            break;
    //    }
    //    Count++;
    //}

    public void Select()
    {
        Console.WriteLine("examine the Switch. . .");
    }


    //int Count = 1;
    private bool power;
    public void Activate()
    {
        #region 주석

            //if (Count % 2 == 0)
            //{
            //    Console.WriteLine("Switck off");
            //}
            //else
            //{
            //    Console.WriteLine("Switch on");
            //}
            //Count++;
            #endregion
        power = !power;

        if (power) 
        {
            Console.WriteLine("The Room Light is on");
        }
        else
        {
            Console.WriteLine("The Room Light is off");
        }

        
    }
}


#region 주석
//if (select != 0)
//{
//    select--;
//    activatable[select].Activate();
//}

//int select;

//ISelectable[] Object =
//    {
//        new Frame(),
//        new Clock(),
//        new Switch()
//    };

//for (int i = 0; i < Object.Length; i++)
//{
//    Console.Write("Select an Object (0 : Frame, 1 : Clock, 2 : Switch) : ");
//    select = int.Parse(Console.ReadLine());
//    if (select >= 0 && select < 3)
//    {
//        Object[select].Select();
//    }
//    else
//        i--;
//}
#endregion

