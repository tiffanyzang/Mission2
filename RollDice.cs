using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        public int[] DiceRollResults(int RollNum)
        {
            //create an array
            int[] arr = new int[13];

            //loop through to get a dice throw for each roll
            for (int roll = 0; roll < RollNum; roll++)
            {
                //generate a random number for "dice 1"
                Random rnd = new Random();
                //assign it to a variable for "dice 1"
                int roll1 = rnd.Next(1, 7);

                //generate a new random number for "dice 2"
                Random rnd2 = new Random();
                //assign it to a variable for "dice 2"
                int roll2 = rnd2.Next(1, 7);

                //total dice roll and access that specific array and add 1 (for rolled once)
                arr[roll1 + roll2]++;
                
            }

            //return array with results
            return arr;

        }

    }
}
