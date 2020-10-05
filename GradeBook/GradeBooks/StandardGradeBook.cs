using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isW) : base(name,isW)
        {
            Type = GradeBookType.Standard;
        }
    }
}
