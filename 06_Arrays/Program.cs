using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Declaration

            //2. 4. 6. 8
            //green, red, blue, orange
            //eskişehir, istanbul, berlin

            //VariableType[] Array_name = new VariableType[Size]

            //string[] colors = new string[4];
            //colors[0] = "Blue";
            //colors[1] = "Red";
            //colors[2] = "White";
            //colors[3] = "Black";

            //Console.WriteLine(colors[2]); //White

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "İstanbul";
            //cities[2] = "Los Angeles";
            //cities[3] = "Berlin";
            //cities[4] = "Taipei";

            //Console.WriteLine(cities[4]); //Taipei

            //int[] number = new int[10];
            //number[0] = 50;
            //number[1] = 48;
            //number[2] = 698;
            //number[3] = 24;
            //number[7] = 748;

            //Console.WriteLine(NumberStyles[5]); // 0


            //string[] cities = { "Rome", "Prague", "Athens" };
            //Console.WriteLine(cities[2]); //Athens
            #endregion

            #region List All Array Elements

            //            string[] colors = { "Yellow", "Blue", "Red", "Green", "Purple", "Orange", "Pink" };
            //            for (int i = 0; i < colors.Length; i++)
            //            {

            //                Console.WriteLine(colors[i]);
            ////Yellow
            ////Blue
            ////Red
            ////Green
            ////Purple
            ////Orange
            ////Pink 

            //            int[] numbers = { 1, 4, 99, 213, 12, 34, 45, 327, 247, 123, 8214 };

            //            for (int i = 0; i < numbers.Length; i++)
            //            {

            //                if (numbers[i] % 3 == 0)
            //                {

            //                    Console.WriteLine(numbers[i]);
            ////99
            ////213
            ////12
            ////45
            ////327
            ////123
            ////8214
            //                }

            //            }

            //            char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //            for (int i = 0; i < symbols.Length; i++)
            //            {
            //                Console.WriteLine(symbols[i]);
            ////a
            ////b
            ////c
            ////*
            /////
            ////-

            //}



            //int[] myArray = { 1, 345, 231, 346, 5672, 15, 178, 45, 765 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{

            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber); //5672


            //string[] people = { "john", "jane", "mark", "oliver", "theo" };
            //Console.WriteLine(people.Length); //5

            //int[] number = { 9, 7, 5, 4, 3, 6, 2, 8, 1 };
            //Array.Sort(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]); //1,2,3,4,5,6,7,8,9
            //}


            //            int[] number = { 9, 7, 5, 4, 3, 6, 2, 8, 1 };
            //            Array.Reverse(number);
            //            for (int i = 0; i < number.Length; i++)
            //            {
            //                Console.WriteLine(number[i]);
            ////1
            ////8
            ////2
            ////6
            ////3
            ////4
            ////5
            ////7
            ////9
            //            }

            #endregion

            #region Array Methods

            //string[] customers = { "john", "jane", "mark", "oliver", "theo" };
            //int index = Array.IndexOf(customers, "theo");
            //    Console.WriteLine(index); //4

            //int[] numbers = { 1, 2, 67, 154, 657, 23, 546 };
            //int maxNumber = numbers.Max();
            //int minNumber = numbers.Min();
            //Console.WriteLine("Maximum number: " + maxNumber); //Maximum number: 657
            //Console.WriteLine("Minimum number: " + minNumber); //Minimum number: 1

            #endregion

            #region Get Array Values from User

            //string[] cities = new string[5];


            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Enter a city name {i + 1}: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();


            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum); //21

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

           
            //Console.WriteLine("Even Numbers:");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

           
            //Console.WriteLine("\nOdd Numbers:");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            #endregion

            Console.Read();
		}
	}
}