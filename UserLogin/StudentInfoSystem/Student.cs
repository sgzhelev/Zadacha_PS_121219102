using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    public partial class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Facultee { get; set; }
        public string Specialtee { get; set; }
        public StudentDegrees Degree { get; set; }
        public string FacNumber { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public int Stream { get; set; }
        public StudentStatus Status { get; set; }
        public string Username { get; set; }
    }
}
