using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


internal class Clock : ISelectable,IActivatable
{
    #region 출력 주석
        //int Count=0;
        //public void Select()
        //{
        //    switch (Count)
        //    {
        //        case 0: Console.WriteLine("examine the Clock. . .");
        //            break;
        //        case 1: Console.WriteLine("어 시계가 이상한데");
        //            break;
        //        case 2: Console.WriteLine("시계가 떨어졌다");
        //            break;
        //    }
        //    Count++;
        //}
        #endregion


    public void Select()
    {
        Console.WriteLine("The Clock is running");
    }

    public void Activate()
    {
        Console.WriteLine("Current Time : " + DateTime.Now.ToString("HH:MM:SS"));
       //DateTime now = DateTime.Now;
       // now.ToString("HH:MM:SS");
        
       // Console.WriteLine(now);
    }
}

