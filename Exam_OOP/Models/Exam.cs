using System;
using System.Collections.Generic;

namespace Exam_OOP.Models
{
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int NoOfQuestion { get; set; }

        
        public int TimeOfExam { get; set; }


        public List<Question> Questions { get; set; }

        protected Exam(int noOfQuestion, int timeOfExam, List<Question> questions)
        {
            NoOfQuestion = noOfQuestion;
            TimeOfExam = timeOfExam;
            Questions = questions;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam other)
        {
            if (other == null) return 1;
            return this.NoOfQuestion.CompareTo(other.NoOfQuestion);
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"NoOfQuestion = {NoOfQuestion}, HoursOfExam = {TimeOfExam}, QuestionsCount = {Questions?.Count}";
        }
    }
}
