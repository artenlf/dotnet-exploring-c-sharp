using DotNetExploringCSharp.Models;

Person person1 = new Person(name: "John", lastname: "Doe");

Person person2 = new Person(name: "Mary", lastname: "Cosby");

Course dotnetCourse = new Course();
dotnetCourse.Name = "DotNet Course";
dotnetCourse.Students = new List<Person>();

dotnetCourse.AddStudent(person1);
dotnetCourse.AddStudent(person2);

dotnetCourse.ListStudents();


