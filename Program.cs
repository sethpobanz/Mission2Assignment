using Mission2Assignment;

public class Program
{
    private static void Main(string[] args)
    {
        RollDice rd = new RollDice();

        string numrolls = "";
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        numrolls = System.Console.ReadLine();

        int[] arrayRolls = rd.RollDiceMethod(numrolls); // Retrieve the array

        // Count occurrences of each sum
        int[] sumCounts = new int[11]; // Indices 0 to 10 represent sums 2 to 12

        foreach (var roll in arrayRolls)
        {
            sumCounts[roll - 2]++;
        }

        // Calculate total number of rolls
        int totalRolls = arrayRolls.Length;
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = 1000.");
        // Print histogram
        for (int i = 0; i < sumCounts.Length; i++)
        {
            int sum = i + 2; // Convert index back to sum value
            double percentage = (double)sumCounts[i] / totalRolls * 100;

            Console.WriteLine($"{sum}: {new string('*', (int)Math.Round(percentage))}");
        }
    }
}
