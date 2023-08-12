namespace H1_Lotto
{
    internal class Program
    {
        static void Main()
        {
            // Creates 3 variables
            Random random = new Random();
            List<int> numbers = new List<int>();
            int joker = 0;

            // Runs a for loop which creates random values and puts them in the list
            for (int i = 0; i < 8; i++)
            {
                // Gets random number and places it inside the list
                int ran = random.Next(1, 37);
                numbers.Add(ran);

                // This makes sure that there is 1 joker
                if (i == 0)
                {
                    joker = random.Next(1, 37);
                }

            }

            // Sorts the numbers in ascending order, except for joker
            numbers.Sort();

            // Runs another for loop, which  outputs each value into the console, except for the joker
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Changes the text color to red and outputs the joker
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(joker);
        }
    }
}