using System;
using System.Collections.Generic;
using Exam_OOP.Models;

namespace Exam_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int examType;
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.WriteLine("Please Enter the type of Exam (1 for Practical | 2 for Final):");
                if (int.TryParse(Console.ReadLine(), out examType) && (examType == 1 || examType == 2))
                    break;
                Console.WriteLine("Invalid input. Enter 1 or 2.");
            }

            int examTime;
            while (true)
            {
                Console.WriteLine("Please Enter The Time For Exam From (30 min to 180 min):");
                if (int.TryParse(Console.ReadLine(), out examTime) && examTime >= 30 && examTime <= 180)
                    break;
                Console.WriteLine("Invalid input. Please enter a number between 30 and 180.");
            }

           
            int numberOfQuestions;
            while (true)
            {
                Console.WriteLine("Enter number of questions:");
                if (int.TryParse(Console.ReadLine(), out numberOfQuestions) && numberOfQuestions > 0)
                    break;
                Console.WriteLine("Invalid input. Enter a positive number.");
            }

            List<Question> questions = new List<Question>();

            
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Clear();
                int qType;
                while (true)
                {
                    Console.WriteLine($"Choose type (1 for MCQ | 2 for True/False):");
                    if (int.TryParse(Console.ReadLine(), out qType) && (qType == 1 || qType == 2))
                        break;
                    Console.WriteLine("Invalid input. Enter 1 or 2.");
                }

                Console.WriteLine("Please Enter Question Body: ");
                string body = Console.ReadLine();

                int mark;
                while (true)
                {
                    Console.WriteLine("Please Enter Question Mark: ");
                    if (int.TryParse(Console.ReadLine(), out mark) && mark > 0)
                        break;
                    Console.WriteLine("Invalid input Enter a positive number.");
                }

                if (qType == 1) // MCQ
                {
                    Answer[] answers = new Answer[3];
                    for (int j = 0; j < 3; j++) // 0 1 2 
                    {
                        Console.WriteLine($"Please Enter Choice number {j + 1}: ");
                        answers[j] = new Answer(j + 1, Console.ReadLine());
                    }

                    int correctId;
                    while (true)
                    {
                      
                        Console.WriteLine("Please Enter The right answer id (1-3): ");
                        if (int.TryParse(Console.ReadLine(), out correctId) && correctId >= 1 && correctId <= 3)
                            break;
                        Console.WriteLine("Invalid input. Enter a number between 1 and 3.");
                    }
                    Console.WriteLine($"MCQ Question   Mark{mark}");
                    questions.Add(new MCQQuestion("MCQ", mark, body, answers, correctId));
                }
                else // True/False
                {
                    int correctId;
                    while (true)
                    {
                        
                        Console.WriteLine("");
                        Console.WriteLine("Please Enter The right answer id (1 for True | 2 for False): ");
                        if (int.TryParse(Console.ReadLine(), out correctId) && (correctId == 1 || correctId == 2))
                            break;
                        Console.WriteLine("Invalid input. Enter 1 or 2.");
                    }

                    bool correct = correctId == 1;
                    questions.Add(new TrueFalseQuestion("True/False", mark, body, correct));
                }
            }

          
            string start;
            while (true)
            {
                Console.Clear();
                Console.Write("Do you Want to start Exam (Y/N): ");
                start = Console.ReadLine().Trim().ToUpper();
                if (start == "Y" || start == "N")
                    break;
                Console.WriteLine("Invalid input. Enter Y or N.");
            }

            if (start == "Y")
            {
                Exam exam;
                if (examType == 1)
                    exam = new PracticalExam(numberOfQuestions, examTime, questions);
                else
                    exam = new Final_Exam(numberOfQuestions, examTime, questions);

                Console.Clear();
                exam.ShowExam();
            }
            else
            {
                Console.WriteLine("Exam cancelled.");
            }
        }
    }
}
