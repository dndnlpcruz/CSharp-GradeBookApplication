using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade) 
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            switch(averageGrade)
            {
                case var gradeLetter when gradeLetter <= 0.2:
                return 'A';

                case var gradeLetter when gradeLetter <= 0.4:
                return 'B';

                case var gradeLetter when gradeLetter <= 0.6:
                return 'C';

                case var gradeLetter when gradeLetter <= 0.8:
                return 'D';

                default:
                return 'F';
            }
        }
    }
}
