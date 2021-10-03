using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_5_Assignment5
{
    class GamblingSimulator
    {

        public void findNumberOfWin()
        {
            int start;
            Console.WriteLine("Enter start = ");
            start = Convert.ToInt32(Console.ReadLine());

            int goal;
            Console.WriteLine("Enter goal = ");
            goal = Convert.ToInt32(Console.ReadLine());

            int win = 0;
            int loose = 0;
            int numberOfBets = 0;
            while (start <= goal)
            {
                Random random = new Random();
                int flip = random.Next(0, 2);

                if (flip ==0)
                {
                    start++;
                    win++;
                    numberOfBets++;
                }
                else
                {
                    loose++;
                    start--;
                    numberOfBets++;
                }
                
            }

            Console.WriteLine("you won" +win+ "times");
            Console.WriteLine("You have " +start+ "Rs left");
            Console.WriteLine("Number of bets made = " +numberOfBets);
        }
    }
}
