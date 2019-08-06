using Entity_FrameworkProject.Models;
using System;
using System.Linq;

namespace Entity_FrameworkProject {
    class Program {
        static void Main(string[] args) {
            //always have to have the 
            var context = new AppDbContext();
            //always start with the context then table collection and then a method
            //".ToList(); is called an extension method and can operate on anything that is a collection
            //(s => s.GPA >= 30) is called Lamda Syntax the "s" on the left of the => represents a collection
            //var students = context.Students
            //.Where(s => s.GPA >= 3.0)
            //.OrderByDescending(s => s.Lastname)
            //.ToArray();

            //var students = context.Students
            //.OrderBy(s => s.Firstname)
            //.ToList();

            var studentAverageSAT = context.Students.Average(s => s.SAT);

            Console.WriteLine($"The average SAT score is {studentAverageSAT}");

            //foreach(var student in students) {
                //Console.WriteLine($"{student.Firstname} {student.Lastname}");
            //}
        }
    }
}
