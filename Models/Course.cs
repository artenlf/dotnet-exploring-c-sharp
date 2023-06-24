using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetExploringCSharp.Models
{
  public class Course
  {
    public string Name { get; set; }

    public List<Person> Students { get; set; }

    public void AddStudent(Person student)
    {
      Students.Add(student);
    }

    public int GetNumberOfStudents()
    {
      int numberOfStudents = Students.Count;

      return numberOfStudents;
    }

    public void RemoveStudent(Person student)
    {
      Students.Remove(student);
    }

    public void ListStudents()
    {
      foreach (Person student in Students)
      {
        Console.WriteLine(student.FullName);
      }
    }
  }
}