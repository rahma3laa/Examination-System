using System.ComponentModel;

namespace Exam_OOP.Models
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public int Mark { get; set; }
        public string Body { get; set; }

        public Question(string header, int mark, string body)
        {
            Header = header;
            Mark = mark;
            Body = body;
        }

        public abstract void ShowQuestion();
    

        
    }
}
