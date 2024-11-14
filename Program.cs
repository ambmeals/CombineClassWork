namespace CombineClassWork
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Coin Flip");
            Console.WriteLine("2. Switch Values");

            string choice = Console.ReadLine();

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid choice.");
                return;
            }


            if (choice != "2")
            {
                Console.Write("Enter the number of coin flips: ");
                int numFlips = int.Parse(Console.ReadLine());

                FlipMultipleCoins(numFlips);
            }
            else
            {
                Console.WriteLine("Enter four integer values separated by spaces:");
                string[] inputs = Console.ReadLine().Split();

                int valueOne = int.Parse(inputs[0]);
                int valueTwo = int.Parse(inputs[1]);
                int valueThree = int.Parse(inputs[2]);
                int valueFour = int.Parse(inputs[3]);

                SwapValues(ref valueOne, ref valueTwo, ref valueThree, ref valueFour);
                Console.WriteLine($"{valueOne} {valueTwo} {valueThree} {valueFour}");
            }
        }

        private static void FlipMultipleCoins(int numFlips)
        {
            Random random = new Random();

            for (int i = 0; i < numFlips; ++i)
                Console.WriteLine(Flip(random));
        }

        private static string Flip(Random random)
        {
            return random.Next(2) == 1
                ? "Heads"
                : "Tails";
        }

        private static void SwapValues(ref int valOne, ref int valTwo, ref int valThree, ref int valFour)
        {
            (valOne, valTwo) = (valTwo, valOne);
            (valThree, valFour) = (valFour, valThree);
        }
    }
}
