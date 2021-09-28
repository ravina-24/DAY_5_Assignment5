using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_5_Assignment5
{
    class FlipCoin
    {

        public void calculatePercentage()
        {
            int Num;

            Console.WriteLine("Enter the Number");
            Num = Convert.ToInt32(Console.ReadLine());

            int countofHeads = 0;
            int countofTail = 0;
            int i = 0;
            while (i <= Num)
            {

                i++;

                Random random = new Random();
                int Flip = random.Next(0,2);

                if (Flip == 0)
                {

                    Console.WriteLine("Tails");
                    countofTail++;
                }

                else if (Flip == 1)
                {


                    Console.WriteLine("Head");
                    countofHeads++;
                }

                double PercentageofHeads = (countofHeads * 100 / Num);
                Console.WriteLine("Percentage of Tail is = " + PercentageofHeads);

                double PercentageOfTails = 100 - PercentageofHeads;
                Console.WriteLine("Percentage of Head is = " + PercentageOfTails);
                Console.WriteLine( );
            }
        }
    }
}



