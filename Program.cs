using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() { "Steve", "Katie", "Tom", "Susie", "Philip" };
            List<string> hometown = new List<string>() { "Detroit, MI", "Tampa, FL", "Seattle, WA", "Austin, TX", "San Francisco, CA" };
            List<string> food = new List<string>() { "cake", "pudding", "fish", "pie", "steak" };
            List<string> hobby = new List<string>() { "mountain climbing", "swimming", "playing video games", "listening to music", "riding a bike" };

            while (true)
            {
                Console.WriteLine("Welcome to our class.  Which student would you like to learn more about? (enter a number 1-5); ");
                //int number = Console.ReadLine();
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number == 1)
                    {
                        Console.WriteLine($"You have selected {students[number - 1]} ");

                        string yes = "y".ToLower();
                        while (yes == "y")
                        {
                            Console.WriteLine($"What do you want to know about {students[number - 1]} (Hometown, Food, Hobby) ");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "hometown")
                            {
                                Console.WriteLine($"{students[number - 1]} was born in {hometown[number - 1]}");
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine($"{students[number - 1]}'s favorite food is {food[number - 1]}");
                            }
                            else if (answer == "hobby")
                            {
                                Console.WriteLine($"{ students[number - 1]} enjoys {hobby[number-1]}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid response. (Hometown, Food, Hobby)");
                            }
                            Console.WriteLine($"Would you like to know more about {students[number - 1]}?(y/n)");
                            yes = Console.ReadLine();
                        }
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine($"You have selected {students[number - 1]} ");

                        string yes = "y".ToLower();
                        while (yes == "y")
                        {
                            Console.WriteLine($"What do you want to know about {students[number - 1]} (Hometown, Food, Hobby) ");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "hometown")
                            {
                                Console.WriteLine($"{students[number - 1]} was born in {hometown[number - 1]}");
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine($"{students[number - 1]}'s favorite food is {food[number - 1]}");
                            }
                            else if (answer == "hobby")
                            {
                                Console.WriteLine($"{ students[number - 1]} enjoys {hobby[number - 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid response. (Hometown, Food, Hobby)");
                            }
                            Console.WriteLine($"Would you like to know more about {students[number - 1]}?(y/n)");
                            yes = Console.ReadLine();
                        }
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine($"You have selected {students[number - 1]} ");

                        string yes = "y".ToLower();
                        while (yes == "y")
                        {
                            Console.WriteLine($"What do you want to know about {students[number - 1]} (Hometown, Food, Hobby) ");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "hometown")
                            {
                                Console.WriteLine($"{students[number - 1]} was born in {hometown[number - 1]}");
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine($"{students[number - 1]}'s favorite food is {food[number - 1]}");
                            }
                            else if (answer == "hobby")
                            {
                                Console.WriteLine($"{ students[number - 1]} enjoys {hobby[number - 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid response. (Hometown, Food, Hobby)");
                            }
                            Console.WriteLine($"Would you like to know more about {students[number - 1]}?(y/n)");
                            yes = Console.ReadLine();
                        }
                    }
                    else if (number == 4)
                    {
                        Console.WriteLine($"You have selected {students[number - 1]} ");

                        string yes = "y".ToLower();
                        while (yes == "y")
                        {
                            Console.WriteLine($"What do you want to know about {students[number - 1]} (Hometown, Food, Hobby) ");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "hometown")
                            {
                                Console.WriteLine($"{students[number - 1]} was born in {hometown[number - 1]}");
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine($"{students[number - 1]}'s favorite food is {food[number - 1]}");
                            }
                            else if (answer == "hobby")
                            {
                                Console.WriteLine($"{ students[number - 1]} enjoys {hobby[number - 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid response. (Hometown, Food, Hobby)");
                            }
                            Console.WriteLine($"Would you like to know more about {students[number - 1]}?(y/n)");
                            yes = Console.ReadLine();
                        }
                    }
                    else if (number == 5)
                    {
                        Console.WriteLine($"You have selected {students[number - 1]} ");

                        string yes = "y".ToLower();
                        while (yes == "y")
                        {
                            Console.WriteLine($"What do you want to know about {students[number - 1]} (Hometown, Food, Hobby) ");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "hometown")
                            {
                                Console.WriteLine($"{students[number - 1]} was born in {hometown[number - 1]}");
                            }
                            else if (answer == "food")
                            {
                                Console.WriteLine($"{students[number - 1]}'s favorite food is {food[number - 1]}");
                            }
                            else if (answer == "hobby")
                            {
                                Console.WriteLine($"{ students[number - 1]} enjoys {hobby[number - 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid response. (Hometown, Food, Hobby)");
                            }
                            Console.WriteLine($"Would you like to know more about {students[number - 1]}?(y/n)");
                            yes = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("That's almost a number between 1 -5.  Please try again. ");
                    }
                }
                catch
                {
                    Console.WriteLine("That's even further away from 1-5....");
                }
                
            }

        }
    }
}

