namespace Infrastructure.Services;
using Domain.Models;


public class  DepartmentService
{
   private List<Department> departments = new List<Department>();
   public List<Department> GetDepartments()
   {
        return departments;
   }
 public void Add(Department department)
{     
    departments.Add(department);
} 
public void Update(Department department, int id)
{
    var search = departments.Find(x=>x.Id==id);
    search.Description = department.Description;
    search.Name = department.Name;
} 
 public Department GetDepartmentById(int id)
 {
    var search = departments.Find(x=>x.Id==id);
    return search;
 }
public void Delete(int id)
{
    var search = departments.Find(x=>x.Id==id);
    departments.Remove(search);
}
public int Count()
{
  int search = departments.Count();
  return search;
}
}
