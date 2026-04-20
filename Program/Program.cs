using System.Diagnostics.Tracing;

namespace Program
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region 추상 클래스
            // 공통적인 기능을 제공하며, 구체적인 동작은 하위 클래스에서
            // 정의할 수 있도록 만들어 놓은 클래스입니다.

            Soldier soldier = null;
            
            int createCount = 0;

            int select = 0;

            while (createCount < 5)
            {

                Console.Write("Select a soldier : ");
                select = int.Parse(Console.ReadLine());
                
               

                createCount++;

                soldier.Attack();
            }
            //Knight knight = new Knight();
            //Archer archer = new Archer();
            //Guard guard = new Guard();
            //int[] soldier = new int[5];
            //for (int i=0; i<5;i++)
            //{
            //    int select = int.Parse(Console.ReadLine());
            //    if (select == 1 || select == 2 || select == 3) 
            //    {
            //        soldier[i] = select;
            //    }
            //    else
            //    {
            //        Console.WriteLine("다시 입력하세요");
            //        i--;
            //    }
                    
                
            //}
            //for (int i=0; i<5; i++)
            //{
            //    if( soldier[i] == 1)
            //    {
            //        knight.Attack();
            //    }
            //    else if( soldier[i] == 2)
            //    {
            //        archer.Attack();
            //    }
            //    else
            //    {
            //        guard.Attack();
            //    }
            //}

            

      

            #endregion

        }
    }
}

