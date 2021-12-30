using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFDBFirstApproach.Entities
{
    public partial class Students
    {
        public Students()
        {
            StudentDivisions = new HashSet<StudentDivisions>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public DateTime? Dob { get; set; }

        public virtual ICollection<StudentDivisions> StudentDivisions { get; set; }
    }
}
