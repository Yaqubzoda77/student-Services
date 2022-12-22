
using Domain.Models;

namespace Infrustructure.Services;
public class StudentServices
{
  public List<Student> Students;
  public StudentServices()
  {
    Students = new List<Student>();
  }
 public List<Student> GetStudents()
  {
    return Students;
  }
  public void AddStudent(Student student)
  {
    Students.Add(student);
  }
  public void UpdateStudent(Student student)
  {
    var Find = Students.FirstOrDefault(x => x.Id == student.Id);
    Find.FirstName = student.FirstName;
    Find.LastName = student.LastName;
    Find.BirthDate = student.BirthDate;
    Find.Addres = student.Addres;
  }
    public void Delete(int Id)
  {
    var Find = Students.FirstOrDefault(x => x.Id == Id);
    Students.Remove(Find);
  }
}
