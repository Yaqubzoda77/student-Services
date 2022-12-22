using Domain.Models;
using Infrustructure.Services;
var students=  new Student();
 students.FirstName = "Muhammad";
 students.LastName = "Yaqubzoda";
 students.Id = 123;

 var students2=  new Student();
 students2.FirstName = "Anushervon";
 students2.LastName = "Bekov";
 students2.Id = 555;


 var studentServices = new StudentServices();
studentServices.AddStudent(students);
studentServices.AddStudent(students2);
foreach (var item in studentServices.GetStudents())
{
    System.Console.WriteLine(item.FirstName+" "+item.LastName );
}
studentServices.Delete(123);
System.Console.WriteLine("\n");

foreach (var item in studentServices.GetStudents())
{
    System.Console.WriteLine(item.FirstName+" "+item.LastName );
}