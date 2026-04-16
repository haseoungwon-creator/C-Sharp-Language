
public class Puzzle
{
    public string word;

    //public Puzzle()
    //{
    //    word = "apple";
    //}
    public void initialize(params string[] list)
    {

        Random random = new Random();

        int index = random.Next(0, list.Length);
        word = list[index];
    }

    public void Render(in int index)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (index == i)
                Console.Write("_ ");
            else
                Console.Write(word[i] + " ");
        }
        Console.WriteLine();

    }



    public void Validate(char input, int index, out bool state)
    {
        if (input == word[index])
        {
            state = true;
        }
        else
        {
            state = false;
        }
    }

    public void Decrease(ref int health)
    {
        Console.WriteLine();
        health--;

        Console.WriteLine("Health : " + health);
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
        bool state = false;

        Puzzle puzzle = new Puzzle();
        Random random = new Random();

        puzzle.initialize("apple", "banana", "orange");

        index = random.Next(0, puzzle.word.Length);

        while (0 < life)
        {


            puzzle.Render(in index);


            char answer = Console.ReadKey().KeyChar;

            Console.WriteLine();


            Console.WriteLine("");

            puzzle.Validate(answer, index, out state);
            if (state)
            {

                break;
            }
            else
            {
                puzzle.Decrease(ref life);
            }

            puzzle.Decrease(ref life);
        }

        if (life >= 0)
        {
            Console.WriteLine("V I C T O R Y");
        }
        else
        {
            Console.WriteLine("D E F E A T");
        }

        //Console.WriteLine(state);
        #endregion
    }
}
