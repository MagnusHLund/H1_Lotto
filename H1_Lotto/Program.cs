namespace H1_Lotto
{
    internal class Program
    {
        static void Main()
        {
            // Creates an array with 8 ints
            int[] numbers = new int[7];

            // Creates 2 variables
            Random random = new Random();
            int joker = 0;

            // Runs a for loop which creates random values and puts them in the array
            for (int i = 0; i < 7; i++)
            {
                // Gets random number
                int ran = random.Next(1, 37);

                // This makes sure that there is 1 joker
                if (i == 0)
                {
                    joker = random.Next(1, 37);

                    // Adds the joker number to the array
                    numbers[6] = joker;
                }

                // If the array already has the number
                if (numbers.Contains(ran))
                {
                    // reduce the for loop int, so the loop runs an additional time, then start loop over
                    i--;
                    continue;
                }

                // Adds the number to the array
                numbers[i] = ran;

            }

            // Sorts the numbers in ascending order, except for joker
            Array.Sort(numbers);

            // Runs another for loop, which  outputs each value into the console, except for the joker
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
                Thread.Sleep(2000);
            }

            // Changes the text color to red and outputs the joker
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(joker);
        }
    }
}
