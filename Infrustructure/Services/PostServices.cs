namespace Infrustructure.Services;
using Domain.Models;
public class PostServices
{       
      public List<Post> Posts;
  public PostServices()
  {
    Posts = new List<Post>();
  }
 public List<Post> GetPost()
  {
    return Posts;
  }
  public void AddPost   (Post posts)
  {
    Posts.Add(posts);
  }
  public void UpdatePst(Post posts)
  {
    var find = Posts.FirstOrDefault(x => x.Id == posts.Id);
    find.Id = posts.Id;
    find.Title = posts.Title;
    find.Description = posts.Description;
  }
    public void Delete(int Id)
  {
    var find = Posts.FirstOrDefault(x => x.Id == Id);
    Posts.Remove(find);
  }

}
