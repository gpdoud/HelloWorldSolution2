using System;

using HelloWorld;

namespace TQL.Bootcamp.Class1 {
    class Program {
        
        readonly string str;

        static void Main(string[] args) {

            var sarah = new Student();
            sarah.Firstname = "Sarah";
            sarah.Lastname = "George";
            sarah.SetHireDate(2017, 6, 26);

            var charlie = new Student();
            charlie.Firstname = "Charlie";
            charlie.Lastname = "Traylor";

            var mattea = new Student();
            mattea.Firstname = "Mattea";
            mattea.Lastname = "Swain";

            sarah.Print();
            charlie.Print();
            mattea.Print();



















            //int? i = null;
            //string s = null;

            //var company = "TQL";
            //var student = "Greg";
            //var years = 2;
            //years = 3;
            //var yesNo = true;
            //{
            //    var x = 0;
            //    Console.WriteLine($"x is {x}");
            //    years = 4;
            //}
            //Console.WriteLine($"Hello World from {student} in C# from {company}!");
            //Console.WriteLine($"My name is {student} and I've been at {company} for {years} years!");
        }
    }
}
