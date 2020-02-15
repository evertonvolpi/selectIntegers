using System;
using System.Collections.Generic;
using System.Linq;

namespace selectIntegers
{
    class Program
    {
        static void Main()
        {
            string valueEntered;
            List<int> evenNum = new List<int>();
            List<int> oddNum = new List<int>();
            List<int> allNum = new List<int>();
            bool verifier = false;
            bool atLeastOne = false;
            bool convertNumber;


            Console.WriteLine("This program selects entered integers in maximum and minimum values,\n odd and even numbers and their respective sum and average values \n\n");

            Console.WriteLine("Press Enter without submiting any value to proceed to the selection process.\n");

            while (verifier == false)
            {
                Console.Write("Enter an Integer: ");
                valueEntered = Console.ReadLine();
                if (string.IsNullOrEmpty(valueEntered))
                {
                    verifier = true;
                }
                else
                {
                    convertNumber = int.TryParse(valueEntered, out int chooseNumber);
                    if (convertNumber)
                    {
                        allNum.Add(chooseNumber);
                        atLeastOne = true;
                    }
                    else
                    {
                        Console.WriteLine("Non integers values are not accepted.");
                        verifier = true;
                    }                    
                }
            }

            Console.WriteLine("" +
                "");

            if (atLeastOne == false)
            {
                Console.Write("You didn't enter an integer. Play again? (Y) > ");
                string playAgain = Console.ReadLine();

                if (playAgain == "y" || playAgain == "Y")
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Goobye!");
                }
            }

            else
            {
                int maxValue = allNum.Max();
                int minValue = allNum.Min();
                int totalEven = 0;
                int totalOdd = 0;
                int sumEven = 0;
                int sumOdd = 0;

                foreach (int num in allNum)
                {
                    if (num % 2 == 0)
                    {
                        evenNum.Add(num);
                        totalEven++;
                        sumEven += num;
                    }
                    else
                    {
                        oddNum.Add(num);
                        totalOdd++;
                        sumOdd += num;
                    }
                }

                Console.WriteLine("The maximum integer you entered is: {0}", maxValue);
                Console.WriteLine("The minimum integer you entered is: {0} \n", minValue);
                
                Console.WriteLine("The number of even integer(s) you entered is: {0}", totalEven);
                if (totalEven != 0)
                {
                    double avgEven = Math.Round(Queryable.Average(evenNum.AsQueryable()), 2);
                    Console.WriteLine("The sum of all even integers you entered is: {0}", sumEven);
                    Console.WriteLine("The average of all even integers you entered is: {0}", avgEven);
                }

                Console.WriteLine("\nThe number of odd integer(s) you entered is: {0}", totalOdd);
                if (totalOdd != 0)
                {
                    double avgOdd = Math.Round(Queryable.Average(oddNum.AsQueryable()), 2);
                    Console.WriteLine("The sum of all odd integers you entered is: {0}", sumOdd);
                    Console.WriteLine("The average of all odd integers you entered is: {0}", avgOdd);
                }

                Console.Write("\nPlay again? (Y) > ");
                string playAgain = Console.ReadLine();

                if (playAgain == "y" || playAgain == "Y")
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Goobye!");
                }
            }
        }
    }
}
