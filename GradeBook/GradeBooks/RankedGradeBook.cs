using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isW) : base(name, isW)
        {
            Type = GradeBookType.Ranked;
        }
        // NOT DONE
        public override char GetLetterGrade(double mainGrade)
        {
            double studentsCount = Students.Count;
            if (studentsCount < 5) throw new InvalidOperationException("Theres less than 5 students in class");
            double twP = studentsCount / 5d ;
            double betterStudentsCount = 0d;
            //int weakerStudentsCount = 0;
            //double avgOfClass = 0;
            foreach (Student student in Students)
            {
                if (student.AverageGrade > mainGrade)
                {
                    betterStudentsCount++;
                    //continue;
                }
                //if(student.AverageGrade < mainGrade)
                //{
                //    weakerStudentsCount++;
                //    continue;
                //}
            }

            if (betterStudentsCount < twP)
                return 'A';
            else if (betterStudentsCount < 2d * twP)
                return 'B';
            else if (betterStudentsCount < 3d * twP)
                return 'C';
            else if (betterStudentsCount < 4d * twP)
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
