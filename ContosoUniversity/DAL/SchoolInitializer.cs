using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {

            var students = new List<Student>();
            students.Add(new Student { FirstName = "Andrew", LastName = "Surname", EnrollmentDate = DateTime.Parse("2015-09-01") });
            students.Add(new Student { FirstName = "Hayley", LastName = "Pendlington", EnrollmentDate = DateTime.Parse("2014-09-01") });
            students.Add(new Student { FirstName = "Stuart", LastName = "Broad", EnrollmentDate = DateTime.Parse("2013-09-01") });
            students.Add(new Student { FirstName = "James", LastName = "Anderson", EnrollmentDate = DateTime.Parse("2012-09-01") });
            students.Add(new Student { FirstName = "Jessica", LastName = "Ashley", EnrollmentDate = DateTime.Parse("2010-09-01") });
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>();
            courses.Add(new Course { CourseID = 1000, Title="Chemistry", Credits=3 });
            courses.Add(new Course { CourseID = 1200, Title = "Business Studies", Credits = 9 });
            courses.Add(new Course { CourseID = 1600, Title = "French", Credits = 5 });
            courses.Add(new Course { CourseID = 1800, Title = "Physics", Credits = 2 });
            courses.Add(new Course { CourseID = 2100, Title = "Accountancy", Credits = 7});
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>();
            enrollments.Add(new Enrollment { StudentID = 1, CourseID = 1000, Grade=Grade.A });
            enrollments.Add(new Enrollment { StudentID = 2, CourseID = 1200, Grade = Grade.B });
            enrollments.Add(new Enrollment { StudentID = 3, CourseID = 1600, Grade = Grade.C });
            enrollments.Add(new Enrollment { StudentID = 4, CourseID = 1800, Grade = Grade.D });
            enrollments.Add(new Enrollment { StudentID = 5, CourseID = 2100, Grade = Grade.B });
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}