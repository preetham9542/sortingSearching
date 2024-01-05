using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingSearching
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\Mphasis Training\\C#\\project 3\\data.txt";
            StudentManager studentManager = new StudentManager(filePath);

            while (true)
            {
                Console.WriteLine("\n1. Display Students\n2. Sort Students by Name\n3. Search Student by Name\n4. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        studentManager.DisplayStudents();
                        break;

                    case "2":
                        studentManager.SortStudentsByName();
                        break;

                    case "3":
                        Console.Write("Enter the student name to search: ");
                        string searchName = Console.ReadLine();
                        studentManager.SearchStudentByName(searchName);
                        break;

                    case "4":
                        studentManager.SaveChangesToFile();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
