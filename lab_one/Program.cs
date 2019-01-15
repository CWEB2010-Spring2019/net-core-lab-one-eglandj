using System;
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



        }

        
    }
}
