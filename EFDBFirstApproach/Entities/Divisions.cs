using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFDBFirstApproach.Entities
{
    public partial class Divisions
    {
        public Divisions()
        {
            StudentDivisions = new HashSet<StudentDivisions>();
        }

        public int Id { get; set; }
        public string Div { get; set; }

        public virtual ICollection<StudentDivisions> StudentDivisions { get; set; }
    }
}
