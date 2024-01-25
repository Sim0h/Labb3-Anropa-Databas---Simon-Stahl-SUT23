using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb3_Anropa_Databas___Simon_Ståhl_SUT23.Models
{
    public partial class TblPersonal
    {
        public TblPersonal()
        {
            TblGrades = new HashSet<TblGrade>();
        }
       
        public int PersonalId { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Occupation { get; set; }

        public virtual ICollection<TblGrade> TblGrades { get; set; }
    }
}
