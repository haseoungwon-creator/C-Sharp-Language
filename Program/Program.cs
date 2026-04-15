using System.Diagnostics.Tracing;

namespace Program
{
 
    public class Puzzle
    {
        public string word;

        public Puzzle()
        {
            word = "apple";
        }

        public void Render(in int index)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if(index == i)
                    Console.Write("_ ");
                else
                    Console.Write(word[i] + " ");
            }
        }

        public void Enter(ref int life)
        {
            life--;
        }

        public void Validate(string input, out bool x)
        {
            if(input == word)
            {
                x = true;
            }
            else
            {
                x= false; 
            }
        }

    }
   
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            #region 매개 변수 한정자
            // 인수가 함수에 전달되는 방식과 사용 규칙을 제어하는 한정자
            int life = 5;
            int index;
            bool state;
            string answer = "apple";
            Puzzle puzzle = new Puzzle();

            puzzle.Enter(ref life);

            Random random = new Random();
            index = random.Next(0,puzzle.word.Length);
            state = puzzle.Validate(answer);
            Console.WriteLine(state);
            

            puzzle.Render(in index);
            #endregion

        }
    }
}
