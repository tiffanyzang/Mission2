using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        //method simulating the rolls
        public int[] DiceRollResults(int RollNum)
        {
            //create an array
            int[] arr = new int[13];

            //loop through to get a dice throw for each roll
            for (int roll = 0; roll < RollNum; roll++)
            {
                //generate a random number for "dice 1" and assign to variable
                Random rnd = new Random();
                int roll1 = rnd.Next(1, 7);

                //generate a random number for "dice 2" and assign to variable
                Random rnd2 = new Random();
                int roll2 = rnd2.Next(1, 7);

                //add dice rolls and access that specific array and add 1
                arr[roll1 + roll2]++;
                
            }

            //return array with results
            return arr;

        }

    }
}
