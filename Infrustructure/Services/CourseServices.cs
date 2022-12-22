namespace Infrustructure.Services;
using Domain.Models;
public class CourseServices
{
    
      public List<Course> Courses;
  public CourseServices()
  {
    Courses = new List<Course>();
  }
 public List<Course> GetCourse()
  {
    return Courses;
  }
  public void AddCourse   (Course courses)
  {
    Courses.Add(courses);
  }
  public void UpdateCourse(Post posts)
  {
    var find = Courses.FirstOrDefault(x => x.Id == posts.Id);
    find.Id = posts.Id;
    find.Title = posts.Title;
    find.Description = posts.Description;
  }
    public void Delete(int Id)
  {
    var find = Courses.FirstOrDefault(x => x.Id == Id);
    Courses.Remove(find);
  }

}
