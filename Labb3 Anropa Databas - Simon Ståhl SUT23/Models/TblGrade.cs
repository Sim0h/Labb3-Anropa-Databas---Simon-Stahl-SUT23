using System;
using System.Collections.Generic;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models
{
    public partial class TblGrade
    {
        public int GradeId { get; set; }
        public int? CourseId { get; set; }
        public int? PersonalId { get; set; }
        public int? StudentId { get; set; }
        public string? Grade { get; set; }
        public DateTime? GradeDate { get; set; }

        public virtual TblCourse? Course { get; set; }
        public virtual TblPersonal? Personal { get; set; }
        public virtual TblStudent? Student { get; set; }
    }
}
