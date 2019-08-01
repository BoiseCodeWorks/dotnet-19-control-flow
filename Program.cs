using System;
using System.Collections.Generic;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            //first List<int> specifies the data type of our numbers variable
            //second List<int> generates a new list by utilizing the new keyword followed by an invokation with the parens - ()
            List<int> numbers = new List<int>();



            while (numbers.Count < 5)
            {
                int numberToAdd;
                while (Int32.TryParse(Console.ReadLine(), out numberToAdd) == false)
                {
                    Console.WriteLine("Not a valid number.\nPlease enter a number.");
                }
                numbers.Add(numberToAdd);
            }


            Console.WriteLine("The greatest number you gave me was " + findGreatestNumber(numbers)); //the variable provided during function invokation is called an argument


            int findGreatestNumber(List<int> nums) // the variable declared at the function definition is called a parameter
            {
                //1. create a placeholder variable for the largest number
                //2. iterate over every number in the list and:
                    //2a. if the current number is larger than the previously saved, then
                    //2b. reassign the variable to the value of 'that' number
                //3. return the variable holding the largest number after the loop ends
                int largestNum = nums[0];
                for (int i = 1; i < nums.Count; i++)
                {
                    //alias the current number
                    int currentNumber = nums[i];
                    if (currentNumber > largestNum)
                    {
                        largestNum = currentNumber;
                    }
                    //don't need to do anything with that number if it's not bigger so excluding the else and else if statements
                }
                return largestNum;
                //return stops 
            }

            // foreach (int currentNumber in numbers)
            // {
            //     Console.WriteLine(currentNumber);
            // }

















            //NOTE  LOOP KEYWORDS:
            //continue - stop current iteration and CONTINUE looping on the next iteration
            //break - stop current iteration and stop iterating because you broke your loop

            // int timer = 10;
            // Console.WriteLine("Countdown in...");
            // while(timer != -1)
            // {
            //     Console.WriteLine(timer);
            //     timer--;
            // }








            // NOTE components of a for loop:
            // 1. initialization
            // 2. condition to run while true
            // 3. afterthought - modifiy the value of the variable used in the condition so that eventually the loop will end
            // for(int i = 0; i < 10; i++) //i+=1 | i = i+1
            // {
            //     if(i == 7)
            //     {
            //         break; 
            //     }
            //     Console.WriteLine(i);
            // }









            // Console.WriteLine("How did you do on that last hole?");
            // int strokes = 0;
            // while (Int32.TryParse(Console.ReadLine(), out strokes) == false)
            // {
            //     Console.WriteLine("Not a valid number.\nPlease enter a number.");
            // }

            //NOTE switch statements look for an exact match between the values of what's being switched on and the case

            // switch (strokes)
            // {
            //     case 1:
            //         Console.WriteLine("Hole in one");
            //         break;
            //     case 2:
            //         Console.WriteLine("Birdie");
            //         break;
            //     case 3:
            //         Console.WriteLine("Par");
            //         break;
            //     case 4:
            //         System.Console.WriteLine("Bogie");
            //         break;
            //     case 5:
            //         System.Console.WriteLine("Double Bogie");
            //         break;
            //     default:
            //         Console.WriteLine("Not your sport.");
            //         break;
            // }












            // string color = "red";



            // if (color == "red")
            // {
            //     // logic here
            // }



            //NOTE the first condition to resolve to true within a chained if/else statement will run and the succeeding conditions won't be evaluted. (I.E., code will jump to the bottom of the chain)
            // if (grade < 60)
            // {
            //     System.Console.WriteLine("F");
            // }
            // else if (grade < 70)
            // {
            //     System.Console.WriteLine("D");
            // }
            // else if (grade < 80)
            // {
            //     System.Console.WriteLine("C");
            // }
            // else if (grade < 90)
            // {
            //     System.Console.WriteLine("B");
            // }
            // else 
            // {
            //     System.Console.WriteLine("A");
            // }

        }
    }
}