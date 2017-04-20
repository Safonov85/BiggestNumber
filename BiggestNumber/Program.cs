using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumber
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Testing a list to get the biggest/smallest number from a list of random generated Numbers");

            int biggestNum = 0;
            int smallestNum = 30;

            // Chooses the biggest and the smallest number var the local variables
            foreach(int num in MakeRandomNumbers())
            {
                Console.WriteLine((num));
                if(biggestNum < num)
                {
                    biggestNum = num;
                }
                if(smallestNum > num)
                {
                    smallestNum = num;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Biggest number in the list is: " + biggestNum);
            Console.WriteLine("Smallest number in the list is: " + smallestNum);
            Console.Read();
        }

        // Creates an int array with 10 random numbers included
        static int[] MakeRandomNumbers()
        {
            int[] randomNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int ran = random.Next(1, 30);
                randomNumbers[i] = ran;
                if(ran == 0)
                {
                    i--;
                }
            }

            return randomNumbers;
        }
    }
}
