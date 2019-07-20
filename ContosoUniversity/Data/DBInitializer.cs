using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Data
{
    public class DBInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students in the database.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-02")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-03")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-10-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-11-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2012-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-22")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2013-09-01")},
            new Student{FirstMidName="Dino",LastName="LilBit",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Carsone",LastName="Alexia",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Mere",LastName="Al",EnrollmentDate=DateTime.Parse("2005-09-02")},
            new Student{FirstMidName="Art",LastName="An",EnrollmentDate=DateTime.Parse("2003-09-03")},
            new Student{FirstMidName="Clip",LastName="Buzz",EnrollmentDate=DateTime.Parse("2002-10-01")},
            new Student{FirstMidName="Yannie",LastName="Lannie",EnrollmentDate=DateTime.Parse("2002-11-01")},
            new Student{FirstMidName="Peg",LastName="Husband",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Lureiel",LastName="Dedfe",EnrollmentDate=DateTime.Parse("2005-09-22")},
            new Student{FirstMidName="Deez",LastName="Nuts",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Die",LastName="Hard",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseId=1050,Title="Chemistry",Credits=3},
            new Course{CourseId=4022,Title="Microeconomics",Credits=3},
            new Course{CourseId=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseId=1045,Title="Calculus",Credits=4},
            new Course{CourseId=3141,Title="Trigonometry",Credits=4},
            new Course{CourseId=2021,Title="Composition",Credits=3},
            new Course{CourseId=2042,Title="Literature",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
            new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
            new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
            new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
            new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
            new Enrollment{StudentId=7,CourseId=1050,Grade=Grade.A},
            new Enrollment{StudentId=8,CourseId=4022,Grade=Grade.C},
            new Enrollment{StudentId=8,CourseId=4041,Grade=Grade.B},
            new Enrollment{StudentId=9,CourseId=1045,Grade=Grade.B},
            new Enrollment{StudentId=9,CourseId=3141,Grade=Grade.F},
            new Enrollment{StudentId=10,CourseId=2021,Grade=Grade.F},
            new Enrollment{StudentId=11,CourseId=1050},
            new Enrollment{StudentId=12,CourseId=1050},
            new Enrollment{StudentId=13,CourseId=4022,Grade=Grade.F},
            new Enrollment{StudentId=14,CourseId=4041,Grade=Grade.C},
            new Enrollment{StudentId=15,CourseId=1045},
            new Enrollment{StudentId=15,CourseId=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
