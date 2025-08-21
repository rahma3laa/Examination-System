namespace Exam_OOP.Models
{
    internal class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string header, int mark, string body, bool correctAnswer)
            : base(header, mark, body)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Body} (Mark: {Mark})");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}

