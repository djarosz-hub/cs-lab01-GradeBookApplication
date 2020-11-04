using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isW) : base(name, isW)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double mainGrade)
        {
            int studentsCount = Students.Count;
            if (studentsCount < 5) throw new InvalidOperationException("Theres less than 5 students in class");
            var twentyPercentBestStudents = (int)Math.Ceiling(studentsCount * 0.2d);

            List<double> grades = Students.OrderByDescending(student => student.AverageGrade).Select(student => student.AverageGrade).ToList();


            if (grades[(twentyPercentBestStudents - 1)] <= mainGrade)
                return 'A';
            else if (grades[(twentyPercentBestStudents * 2) - 1] <= mainGrade)
                return 'B';
            else if (grades[(twentyPercentBestStudents * 3) - 1] <= mainGrade)
                return 'C';
            else if (grades[(twentyPercentBestStudents * 4) - 1] <= mainGrade)
                return 'D';
            else
                return 'F';



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
