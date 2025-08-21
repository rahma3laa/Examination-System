namespace Exam_OOP.Models
{
    internal class Final_Exam :Exam
    {
        public Final_Exam(int noOfQuestion, int hoursOfExam, List<Question> questions)
              : base(noOfQuestion, hoursOfExam, questions)
        {

        }

        public override void ShowExam()
        {
            int totalGrade = 0;
            int studentGrade = 0;
            var startTime = DateTime.Now;

            foreach (var q in Questions)
            {
                Console.WriteLine(q.Body);
                Console.WriteLine($"Mark: {q.Mark}");

                if (q is MCQQuestion mcq)
                {
                    foreach (var ans in mcq.Choices)
                        Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");

                    Console.Write("Your Answer: ");
                    int ansId = int.Parse(Console.ReadLine());

                    if (ansId == mcq.CorrectAnswerId)
                        studentGrade += mcq.Mark ;
                }
                else if (q is TrueFalseQuestion tf)
                {
                    Console.WriteLine("1. True\n2. False");
                    Console.Write("Your Answer: ");
                    int ansId = int.Parse(Console.ReadLine());

                    bool studentAnswer = ansId == 1;
                    if (studentAnswer == tf.CorrectAnswer)
                        studentGrade += tf.Mark ;
                }

                totalGrade += q.Mark ;
                Console.Clear();
            }

            var endTime = DateTime.Now;
            var duration = endTime - startTime;

            Console.WriteLine($"Your Grade: {studentGrade}/{totalGrade}");
            Console.WriteLine($"Time Taken: {duration.TotalMinutes:F2} minutes");
            Console.WriteLine("Thank You!");
        }

    }
}
