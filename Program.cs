using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Task 1:


            //    string[] names = new string[5];
            //    //List<string> planets = new List<string>();
            //    int i = 0;
            //    while (i<names.Length)
            //    {
            //        Console.WriteLine("Please give a name");
            //        names[i] = Console.ReadLine();
            //        i++;
            //    }


            //    foreach (var item in names)
            //    {
            //        Console.WriteLine(item);	


            //Task 2:


            //int[] numbers = new int[10] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };

            //int i = 0;
            //    foreach (var item in numbers)
            //    {
            //        i = i + item;
            //    }


            //    Console.WriteLine("Hello Sum is: " + i);



            //Task 3:


            //List<int> numbers = new List<int>();
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine("Input a number:");
            //    string getnums = Console.ReadLine();

            //    numbers.Add(int.Parse(getnums));
            //    i++;
            //}

            //int j = numbers.Count;
            //Console.WriteLine("Input another number:");
            //string getnumb = Console.ReadLine();
            //int temp = int.Parse(getnumb);
            //foreach (var item in numbers)
            //{
            //    if (item == temp)
            //    {
            //        Console.WriteLine("We have it!");

            //        break;
            //    }
            //    else
            //    {
            //        j--;
            //    }
            //}
            //if (j == 0)
            //{
            //    Console.WriteLine("We dont have it");
            //}





        //Task 4:

            List<int> numbers = new List<int>();
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Input a number:");
                string getnums = Console.ReadLine();

                numbers.Add(int.Parse(getnums));
                i++;
            }

            int j = 0;
            Console.WriteLine("Input another number:");
            string getnumb = Console.ReadLine();
            int temp = int.Parse(getnumb);
            foreach (var item in numbers)
            {
                if (item == temp)
                {


                    j++;
                }

            }
            if (j == 0)
            {
                Console.WriteLine("We dont have it");
            }
            else
            {
                Console.WriteLine("We have it! " + j + " times repeated.");
            }

        }












     

 


    }
    }

