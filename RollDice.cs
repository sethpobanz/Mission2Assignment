using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    internal class RollDice
    {
        public int[] RollDiceMethod(string numRolls)
        {
            int intNumRolls = int.Parse(numRolls);

            int[] arrayRolls = new int[intNumRolls];

            // Creating a Random object for generating random numbers
            Random random = new Random();

            // Loop through each element in the array
            for (int i = 0; i < arrayRolls.Length; i++)
            {
                // Generate two random numbers between 1 and 6
                int firstRoll = random.Next(1, 7);
                int secondRoll = random.Next(1, 7);

                // Add the two numbers and assign the result to the array element
                arrayRolls[i] = firstRoll + secondRoll;
            }

            return arrayRolls; // Return the array
        }

    }
}
