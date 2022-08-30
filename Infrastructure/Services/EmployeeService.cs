namespace Infrastructure.Services;
using Domain.Models;
public class EmployeeService
{
    private List<Employee> employees = new List<Employee>();
   public List<Employee> GetEmployees()
   {
        return employees;
   }
 public void Add(Employee employee)
{     
    employees.Add(employee);
} 
public void Update(Employee employee, int id)
{
    var search = employees.Find(x=>x.Id==id);
    search.FirstName = employee.FirstName;
    search.LastName = employee.LastName;
    search.BirthDate = employee.BirthDate;
    search.Address = employee.Address;
    search.Department = employee.Department;
    search.Experiences = employee.Experiences;
    search.Roles = employee.Roles;
    search.Phone = employee.Phone; 
} 

public List<Role> GetRolesByEmployeeId(int id)
{
    var search = employees.Find(x=>x.Id==id);
    return search.Roles;
}
public List<Experience> GetExperiencesByEmployeeId(int id)
{
    var search = employees.Find(x=>x.Id==id);
    return search.Experiences;
}

 public Employee GetEmployeeById(int id)
 {
    var search = employees.Find(x=>x.Id==id);
    return search;
 }
public void Delete(int id)
{
    var search = employees.Find(x=>x.Id==id);
    employees.Remove(search);
}
public int Count()
{
  int search = employees.Count();
  return search;
}
}
