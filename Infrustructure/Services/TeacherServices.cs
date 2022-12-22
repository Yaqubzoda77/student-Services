using Domain.Models;

namespace Infrustructure.Services;

public class TeacherServices
{
      public List<Teacher> Teachers;
  public TeacherServices()
  {
    Teachers = new List<Teacher>();
  }
 public List<Teacher> GetTeacher()
  {
    return Teachers;
  }
  public void AddTeacher(Teacher teacher)
  {
    Teachers.Add(teacher);
  }
  public void UpdateTeacher(Teacher teacher)
  {
    var find = Teachers.FirstOrDefault(x => x.Id == teacher.Id);
    find.FirstName = teacher.FirstName;
    find.LastName = teacher.LastName;
    find.Position = teacher.Position;
  }
    public void Delete(int Id)
  {
    var find = Teachers.FirstOrDefault(x => x.Id == Id);
    Teachers.Remove(find);
  }
}
