using System;
using System.Linq;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the database context
            using (var context = new StudentContext())
            {
                // Create a new student object
                var student = new Student
                {
                    FirstName = "Asong",
                    LastName = "Tetchounkwi",
                    EnrollmentDate = DateTime.Now
                };

                // Add the student to the Students table
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                // Display confirmation
                Console.WriteLine("Student added successfully!");

                // Optional: list all students
                var allStudents = context.Students.ToList();
                foreach (var s in allStudents)
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName} - Enrolled: {s.EnrollmentDate.ToShortDateString()}");
                }
            }

            // Pause so the window doesn't close immediately
            Console.ReadLine();
        }
    }
}
