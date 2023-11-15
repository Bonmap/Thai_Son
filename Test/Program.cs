using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace hinhchunhat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "SonMc";

            Console.WriteLine(student.Name + "-" + Student.group);
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class Student
    {
        public static string group = "CodeGym";
        public string Name { get; set; }

    }
}