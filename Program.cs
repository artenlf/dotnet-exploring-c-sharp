using DotNetExploringCSharp.Models;

Person person1 = new Person();

person1.Name = "John";
person1.LastName = "Doe";

Person person2 = new Person();

person2.Name = "Mary";
person2.LastName = "Cosby";

Course dotnetCourse = new Course();
dotnetCourse.Name = "DotNet Course";
dotnetCourse.Students = new List<Person>();

dotnetCourse.AddStudent(person1);
dotnetCourse.AddStudent(person2);

dotnetCourse.ListStudents();


