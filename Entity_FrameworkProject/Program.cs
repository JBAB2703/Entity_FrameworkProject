using Entity_FrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Entity_FrameworkProject {
    public class Program {

        public static Student GetStudentByLastname(string lastname) {
            var db = new AppDbContext();
            var students = db.Students.Where(s => s.Lastname.Equals(lastname)).ToArray();
            if(students.Count() == 0) {
                return null;
            } else {
                return students[0];
            }
        }


        public static Student GetStudentById(int id) {
            var db = new AppDbContext();
            return db.Students.Find(id);
        }

        static void Main(string[] args) {

           

            //always have to have the var context = new AppDbContext();
            //create an instance of the context
            var context = new AppDbContext();
            //get the student
            var student = context.Students.SingleOrDefault(s => s.Lastname == "Rogers");
            //get the courses
            var courses = context.Courses.Where(c => c.Name.Contains("101")).ToArray();
            //schedule the student for all the courses
            foreach (var course in courses) {
                var schedule = new Schedule {
                    StudentId = student.Id,
                    CourseId = course.Id,
                    Grade = -1,

                };

                    context.Schedules.Add(schedule);
            }
            
        

            //save to the database
            context.SaveChanges();

            //var major = context.Majors.SingleOrDefault(m => m.Description == "eSports");

            //var course = new Course {
            //    Name = "Minecraft 101",
            //    Instructor = "B. Kyle",
            //    Credit = 3,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Theater");

            //course = new Course {
            //    Name = "Marvel 101",
            //    Instructor = "A. Kyle",
            //    Credit = 5,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Biology");

            //course = new Course {
            //    Name = "Ice Age 201",
            //    Instructor = "S. Sloth",
            //    Credit = 4,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Golf Science");

            //course = new Course {
            //    Name = "Slice 304",
            //    Instructor = "B. Watson",
            //    Credit = 4,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);

            //major = context.Majors.SingleOrDefault(m => m.Description == "History");

            //course = new Course {
            //    Name = "American History",
            //    Instructor = "G. Washington",
            //    Credit = 4,
            //    MajorId = major.Id,
            //};
            //context.Courses.Add(course);


            //var major = context.Majors.SingleOrDefault(m => m.Description == "eSports");

            //var student = new Student {
            //    Firstname = "Jay",
            //    Lastname = "Bird",
            //    GPA = 2.8,
            //    SAT = 1100,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};
            //context.Students.Add(student);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Public Speaking");

            //student = new Student {
            //    Firstname = "Patrick",
            //    Lastname = "Star",
            //    GPA = 1.7,
            //    SAT = 650,
            //    IsFulltime = false,
            //    MajorId = major.Id,
            //};
            //context.Students.Add(student);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Theater");

            //student = new Student {
            //    Firstname = "Jimmy",
            //    Lastname = "Neutron",
            //    GPA = 5.0,
            //    SAT = 2400,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};
            //context.Students.Add(student);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Golf Science");

            //student = new Student {
            //    Firstname = "Timmy",
            //    Lastname = "Turner",
            //    GPA = 2.5,
            //    SAT = 1300,
            //    IsFulltime = true,
            //    MajorId = major.Id,
            //};
            //context.Students.Add(student);

            //major = context.Majors.SingleOrDefault(m => m.Description == "Socialogy");

            //student = new Student {
            //    Firstname = "Steve",
            //    Lastname = "Rogers",
            //    GPA = 4.6,
            //    SAT = 1000,
            //    IsFulltime = false,
            //    MajorId = major.Id,
            //};


            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSat = 1100;
            //context.Majors.Add(major);

            //removing data in the table
            //var major = context.Majors.Find(5);
            //context.Remove(major);

            //change in the table
            //var major = context.Majors.Find(2);
            //if(major == null) {
            //throw new Exception("Not Found");
            //}
            //major.Description = "Math";
            //major.MinSat = 1300;

            //add an instance of Major

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSat = 1100;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Accounting";
            //major.MinSat = 1300;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Public Speaking";
            //major.MinSat = 5;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Golf Science";
            //major.MinSat = 1400;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "eSports";
            //major.MinSat = 800;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Socialogy";
            //major.MinSat = 800;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "History";
            //major.MinSat = 900;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Political Science";
            //major.MinSat = 1000;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Theater";
            //major.MinSat = 200;
            //context.Majors.Add(major);

            //major = new Major();
            //major.Id = 0;
            //major.Description = "Computer Science";
            //major.MinSat = 1500;
            //context.Majors.Add(major);



            //always start with the context then table collection and then a method
            //".ToList(); is called an extension method and can operate on anything that is a collection
            //(s => s.GPA >= 30) is called Lamda Syntax the "s" on the left of the => represents a collection
            //var students = context.Students
            //.Where(s => s.GPA >= 3.0)
            //.OrderByDescending(s => s.Lastname)
            //.ToArray();

            //foreach(var major in context.Majors.ToList()){
            //Console.WriteLine(major);
            //}

            //var genStudies = context.Majors.Find(1);
            //Console.WriteLine(genStudies);

            //var students = context.Students
            //.OrderBy(s => s.Firstname)
            //.ToList();

            //var studentAverageSAT = context.Students.Average(s => s.SAT);

            //Console.WriteLine($"The average SAT score is {studentAverageSAT}");

            // var students = context.Students
            //.Where(student => student.Major != null)
            //.OrderBy(student => student.Major.Description)
            //.ToList();

            //foreach (var student in students) {
            //var major = (student.Major == null) ? "Undeclared" : student.Major.Description;
            //Console.WriteLine(student);
            //}
            }
    }
}
