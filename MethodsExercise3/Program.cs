using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            counter();
            Console.WriteLine(counterTwo(2, 8));
            isOdd(6);
            positiveNegative(-1);
            userAge();

        }

        private static void counter()
        {
            //Write a method that will print to the console all numbers 1000 through -1000
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($" Result in Counter {i}");
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static bool counterTwo(int a, int b)
        {

            var check = (a == b) ? true : false;

            return check;
        }

        public static bool isOdd(int num1)
        {
            //Write a method to check whether a given number is even or odd.


            if (num1 % 5 == 1)
            {
                Console.WriteLine($"It is Odd");
                return true;
            }
            else
            {
                Console.WriteLine($"It is even");
                return false;
            }

        }


        //Write a method to check whether a given number is positive or negative.
        public static void positiveNegative(int nuM)
        {
            if (nuM > -1)
            {

                Console.WriteLine($"It is Positive");


            }
            else
            {
                Console.WriteLine($"It is negative");


            }


        }

        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void userAge()
        {

            Console.WriteLine(" How old are you");
            var age = new Random();
            var legalAge = age.Next(19, 100);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > legalAge)
            {
                Console.WriteLine($"{userInput} You can vote!");

            }
            else
            {

                Console.WriteLine("You must be 19 or above to vote");


            }

        }
    }
}



    












