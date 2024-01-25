using System;
using System.Collections.Generic;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models
{
    public partial class TblStudent
    {
        public TblStudent()
        {
            TblGrades = new HashSet<TblGrade>();
        }

        public int StudentId { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int? Pnumber { get; set; }
        public string? Class { get; set; }

        public virtual ICollection<TblGrade> TblGrades { get; set; }
    }
}
