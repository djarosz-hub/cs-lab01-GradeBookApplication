using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isW) : base(name, isW)
        {
            Type = GradeBookType.Ranked;
        }
        // NOT DONE
        public override char GetLetterGrade(double grade)
        {
            int studentsCount = Students.Count;
            if (studentsCount < 5) throw new InvalidOperationException("Theres less than 5 students in class");
            return 'A';
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked grading requires at least 5 students.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
