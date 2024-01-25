using System;
using System.Collections.Generic;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models
{
    public partial class TblCourse
    {
        public TblCourse()
        {
            TblGrades = new HashSet<TblGrade>();
        }

        public int CourseId { get; set; }
        public string? CourseName { get; set; }

        public virtual ICollection<TblGrade> TblGrades { get; set; }
    }
}
