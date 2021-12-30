using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFDBFirstApproach.Entities
{
    public partial class StudentDivisions
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DivisionId { get; set; }
        public string AcaYear { get; set; }
        public string ClassTeacherName { get; set; }

        public virtual Divisions Division { get; set; }
        public virtual Students Student { get; set; }
    }
}
