using System;
using System.Threading;
using System.Collections.Generic;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array that holds Correct Answers
            string[] correctAnswers = { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //An Array for end-users selection
            //string[] userSelection;

            string[] quizQuestions = {"When was .NET core released?", "What is the current version of .NET core?","What operating system does not support .Net Core?",
                                      "Who created .NET Core?", ".NET Core is compatible with...", "What does .NET Core use to be compatible with .NET Framework, Xamarin and Mono?",
                                      "What language is not supported by .NET Core?", "What framework was not built on top of .NET Core?",
                                      ".NET Core is composed of components that are distributed in...", "Who is .NET Core liscensed by?"};

            //Declare a Multi-dimensional array that holds options for each question
            string[,] quizQuestionOptions = {
                                            {"A) 2019", "B) 2016", "C) 2003", "D) 1990"},
                                            {"A) 1.0", "B) 2.2", "C) 2.0", "D) 1.5"},
                                            {"A) Linux", "B) Window", "C) IOS", "D) macOS"},
                                            {"A) Microsoft", "B) Windows", "C) Apple", "D) Android"},
                                            {"A) .NET Framework", "B) Xamarin", "C) Mono", "D) All the above"},
                                            {"A) .NET Standard", "B) .NET Foundation", "C) .NET Docker", "D) .NET Core Creator"},
                                            {"A) Python", "B) F#", "C) Visual Basic", "D) C#"},
                                            {"A) ASP.NET Core", "B) UWP", "C) ARM", "D) Tizen"},
                                            {"A) .NET Core Runtime", "B) ASP.NET Core Runtime", "C) .NET Core SDK", "D) All the above"},
                                            {"A) Both B & C", "B) MIT", "C) Apache2", "D) Microsoft"}
                                        };
            //Declaring a string that whill hold the users answers
            string[] userSelection = new string[10];

            bool hello = true;

            while (hello == true)
            {
                //Declaring console keys for user to start or exit test
                ConsoleKey start = ConsoleKey.Enter;
                ConsoleKey userKey = new ConsoleKey();
                ConsoleKey EXIT = ConsoleKey.Spacebar;

                while (userKey != start)
                {
                    Console.WriteLine("Welcome, this program will assess your knowledge of .NET Core");
                    Console.WriteLine("To get started, please hit ENTER to start the program");
                    userKey = Console.ReadKey().Key;
                    Console.Clear();
                }
                //Creating a string to hold only the correct answers
                List<string> correct = new List<string>();

                //For loop generating the question for the user
                for (int i = 0; i < quizQuestions.Length; i++)
                {

                    Console.Clear();
                    Console.WriteLine(quizQuestions[i] + "\n");

                    //For loop generating options for the quiz questions
                    for (int n = 0; n < quizQuestionOptions.GetLength(1); n++)
                    {
                        Console.WriteLine(quizQuestionOptions[i, n]);
                    }
                    //Informing user to select an option and changing their option to a capital letter
                    Console.WriteLine("\nPlease enter an option.");
                    userSelection[i] = Console.ReadLine().ToUpper();

                    //If statement determining wether the question was correct or incorrect
                    if (userSelection[i] == correctAnswers[i])
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("CORRECT");
                        for (int b = 0; b < 3; b++)
                        {
                            Console.Beep(2800, 100);
                        }
                        correct.Add(userSelection[i]);
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("INCORRECT");
                        Console.Beep(800, 1000);

                    }
                    //Resetting the console to black after each loop
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.Clear();

                //Creating a table of the users answers and the correct answers and turning them a specific color based on if the user answered correctly
                Console.WriteLine("Here are your answers and the correct answers.\n");
                for (int a = 0; a < quizQuestions.Length; a++)
                {

                    if (userSelection[a] == correctAnswers[a])
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    string num = "";
                    if (a < 9)
                    {
                        num = "0";
                    }
                    Console.WriteLine(" " + num + (a + 1) + "  |  " + userSelection[a] + "  |  " + correctAnswers[a] + "   ");

                }

                //Resetting the console color to black and using an if statement to prompt the user
                Console.BackgroundColor = ConsoleColor.Black;
                if (correct.Count > 6)
                {
                    Console.WriteLine("\nYou got " + correct.Count + " / 10 correct!");
                    Console.WriteLine("Congratulations! You Passed!\n");
                }
                else
                {
                    Console.WriteLine("\nYou got " + correct.Count + " / 10 correct...");
                    Console.WriteLine("Sorry... You Failed...\n");
                }

                //Statement telling the user their options and waiting for a key press
                Console.WriteLine("Please press ENTER to try again\n\nPress SPACEBAR to Exit");

                //Resetting userKey
                userKey = Console.ReadKey().Key;

                //Resetting user options if they press any key other than ENTER or SPACE BAR
                while (userKey != start && userKey != EXIT)
                {
                    Console.Clear();
                    Console.WriteLine("Please press ENTER to try again\n\nPress SPACEBAR to Exit");
                    userKey = Console.ReadKey().Key;
                }

                Console.Clear();

                //Ends the program if user desires
                if (userKey == EXIT)
                {
                    hello = false;
                }
                
            }
        }
    }
}
