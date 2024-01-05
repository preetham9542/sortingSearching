// FileHandler.cs
using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    private string filePath;

    public FileHandler(string filePath)
    {
        this.filePath = @"D:\\Mphasis Training\\C#\\project 3\\data.txt";
    }

    public List<Student> ReadStudentsFromFile()
    {
        List<Student> students = new List<Student>();

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length == 2)
                {
                    students.Add(new Student { Name = data[0].Trim(), Class = data[1].Trim() });
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please create the file with student data.");
        }

        return students;
    }

    public void WriteStudentsToFile(List<Student> students)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Name}, {student.Class}");
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error writing to the file.");
        }
    }
}
