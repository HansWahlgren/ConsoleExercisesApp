﻿using System;

namespace ConsoleExercisesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selectionNumber)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            RunExerciseSeven();
                            break;
                        case 8:
                            RunExerciseEight();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseForteen();
                            break;

                        // Add new cases as you progress with your exercises

                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid assigment number!");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            string firstName = ("Philip ");
            string lastName = ("wahlgren ");
            Console.WriteLine("Hello " + firstName + lastName + "Good job");
        }

        private static void RunExerciseTwo()
        {
            DateTime lastDay = DateTime.Now.AddDays(-1); ;
            DateTime thisDay = DateTime.Now;
            DateTime tomorrowDay = DateTime.Now.AddDays(1);

            Console.WriteLine("Todays date is " + thisDay);
            Console.WriteLine("Yesterdays date is " + lastDay);
            Console.WriteLine("Tomorrows date is " + tomorrowDay);
        }

        private static void RunExerciseThree()
        {
            Console.Write("Write your firstname: ");
            string firstName = Console.ReadLine();
            Console.Write("Write your lastname: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1} ", firstName, lastName);
            Console.WriteLine($"Hello {firstName} {lastName} ");
            RunExerciseTwo();
        }

        private static void RunExerciseFour()
        {
            var wrongStr = "The quick fox Jumped Over the DOG";

            // First Line
            var changeWord = wrongStr.Remove(13);
            changeWord = changeWord.Replace("quick", "brown");

            // Second Line
            var addWord = wrongStr.Substring(13);
            addWord = addWord.ToLower();
            addWord = addWord.Insert(17, "lazy ");

            var fullWord = changeWord + addWord;
            Console.WriteLine(fullWord);
        }

        private static void RunExerciseFive()
        {
            var str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            var firstNumbers = str.Substring(65);
            firstNumbers = firstNumbers.Remove(2, 4);

            //firstNumbers = firstNumbers.Insert(6,",6,7,8,9,10");
            var newNumbers = new string[5] { "6", "7", "8", "9", "10" };
            var lastNumbers = string.Join(",", newNumbers);

            lastNumbers = lastNumbers.Insert(0, ",");
            var allNumbers = firstNumbers.Insert(6, lastNumbers);
            Console.WriteLine(allNumbers);
        }

        private static void RunExerciseSix()
        {
            Console.WriteLine("Enter two numbers");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double biggestNumber;
            double smallestNumber;

            if (firstNumber > secondNumber)
            {
                biggestNumber = firstNumber;
                smallestNumber = secondNumber;
            }
            else
            {
                biggestNumber = secondNumber;
                smallestNumber = firstNumber;
            }

            Console.WriteLine("The biggest number: " + biggestNumber);
            Console.WriteLine("The Smallest number: " + smallestNumber);
            Console.WriteLine("The difference of the numbers: " + (biggestNumber - smallestNumber));
            Console.WriteLine("The sum of the numbers: " + (biggestNumber + smallestNumber));
            Console.WriteLine("The product of the numbers: " + (biggestNumber * smallestNumber));
            Console.WriteLine("The ratio of the numbers: " + (biggestNumber / smallestNumber));
        }

        private static void RunExerciseSeven()
        {
            double radius = double.Parse(Console.ReadLine());
            double piValue = Math.PI;
            double volume = (4 * piValue * Math.Pow(radius, 3)) / 3;
            double area = 2 * piValue * Math.Pow(radius, 2);

            Console.WriteLine("The volume of the circle is: " + volume);
            Console.WriteLine("The area of the circle is" + area);
        }

        private static void RunExerciseEight()
        {
            double number = double.Parse(Console.ReadLine());
            /*
            number = Math.Sqrt(number);
            Console.WriteLine("Square root is: " + number);
            number = Math.Pow(number, 2);
            Console.WriteLine("Raised by 2: " + number);
            number = Math.Pow(number, 10);
            Console.WriteLine("Raised by 10: " + number);
            */
            Console.WriteLine($"Square root is: {number = Math.Sqrt(number)} " +
                $"Raised by 2: {number = Math.Pow(number, 2)} Raised by 10: {Math.Pow(number, 10)}");
        }

        private static void RunExerciseNine()
        {

            Console.WriteLine("Hi, what is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName} and welcome, how old are you? (Example: 1990-10-31)");
            string userInput = Console.ReadLine();
            DateTime birthDay = DateTime.Parse(userInput);
            //Console.WriteLine(birthDay.ToShortDateString());

            DateTime dateNow = DateTime.Now;
            TimeSpan dateDiff = dateNow.Subtract(birthDay);
            Console.WriteLine(dateDiff);

            if (dateDiff.Days > 6570)
            {
                Console.WriteLine("Do you want to order a beer? (Yes / No)");
                string userOrder = Console.ReadLine();

                if ((userOrder == "Yes") || (userOrder == "yes"))
                {
                    Console.WriteLine("Your beer has been served");
                }
                else
                {
                    Console.WriteLine("Do you want to order a coke? (Yes / No)");
                    userOrder = Console.ReadLine();

                    if ((userOrder == "Yes") || (userOrder == "yes"))
                    {
                        Console.WriteLine("Your coke has been served");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no other order options are avaliable");
                    }
                }
            }
            else
            {
                Console.WriteLine("Do you want to order a Coke? (Yes / No)");
                string userOrder = Console.ReadLine();

                if ((userOrder == "Yes") || (userOrder == "yes"))
                {
                    Console.WriteLine("Your coke has been served");
                }
                else
                {
                    Console.WriteLine("Sorry, no other order options are avaliable");
                }
            }

        }

        private static void RunExerciseTen()
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine("Enter option number 1-3 or 4 to exit");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        RunUserNumbers();
                        break;

                    case 2:
                        RunExerciseFour();
                        break;

                    case 3:
                        if (Console.ForegroundColor == ConsoleColor.Blue)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("This is now yellow");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("This is now blue");
                        }
                        break;

                    case 4:
                        keepAlive = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
        }

        private static void RunUserNumbers()
        {
            Console.WriteLine("Enter a number");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number (Not 0)");
            double numberB = double.Parse(Console.ReadLine());

            if(numberB == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            else
            {
                Console.WriteLine(numberA / numberB);
            }
        }

        private static void RunExerciseEleven()
        {
            Console.WriteLine("Type a number greater then 0!");
            double userNumber = double.Parse(Console.ReadLine());
            if(userNumber > 0)
            {
                for(int i=0; i <= userNumber; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(i);
                }

                Console.WriteLine("------------");
                
                for (int i = 0; i <= userNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(userNumber - i);
                }
            }

            else
            {
                Console.WriteLine("You need a greater number then 0!");
            }
            
        }

        private static void RunExerciseTwelve()
        {
            Console.WriteLine("Nothing Here");
        }

        private static void RunExerciseThirteen()
        {
            Console.WriteLine("Nothing Here");
        }

        private static void RunExerciseForteen()
        {
            Console.WriteLine("Nothing Here");
        }

        // Cerate your exercise methods here
    }
}