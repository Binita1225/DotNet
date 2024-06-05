using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string Program { get; set; }
    public char Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // List of students
        List<Student> students = new List<Student>
        {
            new Student { Name = "John", Program = "BCA", Grade = 'A' },
            new Student { Name = "Alice", Program = "BBA", Grade = 'B' },
            new Student { Name = "Bob", Program = "BCA", Grade = 'A' },
            new Student { Name = "Charlie", Program = "MCA", Grade = 'A' },
            new Student { Name = "David", Program = "BCA", Grade = 'B' },
        };

        // LINQ query to find students with grade "A" and program "BCA"
        var result = from student in students
                     where student.Grade == 'A' && student.Program == "BCA"
                     select student;

        // Displaying the result
        Console.WriteLine("Students with grade 'A' and program 'BCA':");
        foreach (var student in result)
        {
            Console.WriteLine($"Name: {student.Name}, Program: {student.Program}, Grade: {student.Grade}");
        }
    }
}
