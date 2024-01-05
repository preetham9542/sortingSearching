// StudentManager.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class StudentManager
{
    private List<Student> students;
    private FileHandler fileHandler;

    public StudentManager(string filePath)
    {
        fileHandler = new FileHandler(filePath);
        students = fileHandler.ReadStudentsFromFile();
    }

    public void DisplayStudents()
    {
        Console.WriteLine("Student List:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}, {student.Class}");
        }
    }

    public void SortStudentsByName()
    {
        students = students.OrderBy(s => s.Name).ToList();
        Console.WriteLine("Students sorted by name.");
    }

    public void SearchStudentByName(string name)
    {
        var searchResults = students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();

        if (searchResults.Any())
        {
            Console.WriteLine("Search Results:");
            foreach (var result in searchResults)
            {
                Console.WriteLine($"{result.Name}, {result.Class}");
            }
        }
        else
        {
            Console.WriteLine($"No students found with the name '{name}'.");
        }
    }

    public void SaveChangesToFile()
    {
        fileHandler.WriteStudentsToFile(students);
    }
}
