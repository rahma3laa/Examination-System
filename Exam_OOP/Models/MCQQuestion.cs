namespace Exam_OOP.Models
{
    internal class MCQQuestion : Question
    {
        public Answer[] Choices { get; set; }
        public int CorrectAnswerId { get; set; }

        public MCQQuestion(string header, int mark, string body, Answer[] choices, int correctAnswerId)
            : base(header, mark, body)
        {
            Choices = choices;
            CorrectAnswerId = correctAnswerId;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Body} (Mark: {Mark})");
            foreach (var choice in Choices)
                Console.WriteLine($"{choice.AnswerId}. {choice.AnswerText}");
        }
    }



}

