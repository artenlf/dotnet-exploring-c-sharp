using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetExploringCSharp.Models
{
  public class Person
  {
    private string _name;

    private string _lastName;
    private int _age;

    public string Name
    {
      get => _name; // Example of body expression

      set
      {
        if (value == "")
        {
          throw new ArgumentException("Name cannot be empty");
        }

        _name = value;
      }
    }

    public string LastName
    {
      get => _lastName;
      set
      {
        if (value == "")
        {
          throw new ArgumentException("Last Name cannot be empty");
        }

        _lastName = value;
      }
    }

    public string FullName => $"{Name} {LastName}".ToUpper();


    public int Age
    {
      get => _age;

      set
      {
        if (value < 0)
        {
          throw new ArgumentException("Age cannot be negative");
        }

        _age = value;
      }
    }

    public void IntroducePerson()
    {
      Console.WriteLine($"Name: {FullName}, Age: {Age}");
    }
  }
}