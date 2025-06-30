using System;

namespace StudentApp
{
    public class Student
    {
        public int StudentId { get; set; }         // Primary key
        public string FirstName { get; set; }      // Student's first name
        public string LastName { get; set; }       // Student's last name
        public DateTime EnrollmentDate { get; set; } // Date the student enrolled
    }
}
