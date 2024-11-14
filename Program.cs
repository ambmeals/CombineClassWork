namespace CombineClassWork
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Coin Flip");
                Console.WriteLine("2. Switch Values");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                if (choice == "3")
                    break;

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                if (choice == "1")
                {
                    Console.Write("Enter the number of coin flips: ");

                    if (int.TryParse(Console.ReadLine(), out int numFlips))
                        FlipMultipleCoins(numFlips);
                    else
                        Console.WriteLine("Invalid number of flips.");
                }
                else
                {
                    Console.WriteLine("Enter four integer values separated by spaces:");
                    string[] inputs = Console.ReadLine().Split();

                    if (inputs.Length == 4 &&
                        int.TryParse(inputs[0], out int valueOne) &&
                        int.TryParse(inputs[1], out int valueTwo) &&
                        int.TryParse(inputs[2], out int valueThree) &&
                        int.TryParse(inputs[3], out int valueFour))
                    {
                        SwapValues(ref valueOne, ref valueTwo, ref valueThree, ref valueFour);
                        Console.WriteLine($"{valueOne} {valueTwo} {valueThree} {valueFour}");
                    }
                    else
                        Console.WriteLine("Invalid input. Please enter four integers.");
                }

                Console.WriteLine();
            }
        }

        private static void FlipMultipleCoins(int numFlips)
        {
            Random random = new Random();

            for (int i = 0; i < numFlips; ++i)
                Console.WriteLine(Flip(random));
        }

        private static string Flip(Random random) => random.Next(2) == 1 
            ? "Heads" 
            : "Tails";

        private static void SwapValues(ref int valOne, ref int valTwo, ref int valThree, ref int valFour)
        {
            (valOne, valTwo) = (valTwo, valOne);
            (valThree, valFour) = (valFour, valThree);
        }
    }
}
