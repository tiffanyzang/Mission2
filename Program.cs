using Mission2;
public class Program
{
    private static void Main(string[] args)
    {
        //new RollDice class
        RollDice dr = new RollDice();

        //create variable for player input
        string RollInput = "";

        //create variable for number of rolls
        int RollNum = 0;

        //Write welcome message and ask for user input
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        //user input
        RollInput = System.Console.ReadLine();

        //change user input to integer
        RollNum = int.Parse(RollInput);

        int[] array = dr.DiceRollResults(RollNum);

        //Write the result message with total number of rolls 
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" +
        "Each \"*\" represents 1% of the total number of rolls.\n" +
        "Total Number of Rolls = " + RollNum + "\n");

        //loop to create the histogram
        for (int rollResult = 2; rollResult < 13; rollResult++) 
        {
            //print each of the possible roll values (2-12)
            System.Console.Write(rollResult + ": ");

            //calculate the percentage
            int rollpercent = (array[rollResult] * 100 / RollNum);

            //print the number of stars based off of the percentage 
            for (int stars = 0; stars < rollpercent; stars++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }

        //Write ending message to end the simulator 
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");


    }
}

