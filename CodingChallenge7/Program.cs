namespace CodingChallenge7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PlayTheGame();
        }

        public static void CubicNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Current Number is : {i} and the cube is {Math.Pow(i, 3)}\n");
            }
        }

        public static void PlayTheGame()
        {
            Console.Write("Enter your desired number => ");
            string input = Console.ReadLine();
            int target;
            if(int.TryParse(input, out target))
            {
                CubicNumber(target);
            } else
            {
                Console.WriteLine("Your input must be a valid number");
            }
        }
    }
}