﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP.Models
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }

        public void ShowSubjectExam()
        {
            Console.WriteLine($"Subject: {SubjectName}");
            Exam?.ShowExam();
        }
    }
}
