using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemyPractice11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
            //display an error message and ask the user to re-try. Once the user successfully enters 5 unique 
            //numbers, sort them and display the result on the console.
            var numList = new List<int>();
            int nums;

            Console.WriteLine("This program will ask you to enter 5 different numbers.  When you finish, it will sort them from lowest to highest.");
            Console.WriteLine();//blank

            do
            {   
                Console.WriteLine("Please enter a number: ");
                nums = int.Parse(Console.ReadLine());
                
                //protect against duplicates going in
                if (numList.Contains(nums))
                {
                    Console.WriteLine("Error.  You already entered that number.");
                }
                else if (!numList.Contains(nums)) // if not a duplicate, add it
                {
                    numList.Add(nums);
                }

            } while (numList.Count < 5);

            Console.WriteLine();//blank

            Console.WriteLine("Sorted numbers:");
            numList.Sort();

            foreach (var n in numList)
            {
                Console.WriteLine(n);
            }


        }
    }
}
