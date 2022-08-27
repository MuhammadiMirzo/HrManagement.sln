namespace Infrastructure.Services;
using Domain.Models;
public class  RoleService
{
     private List<Role> roles = new List<Role>();
   public List<Role> GetRoles()
   {
        return roles;
   }
 public void Add(Role role)
{     
    roles.Add(role);
} 
public void Update(Role role, int id)
{
    var search = roles.Find(x=>x.Id==id);
    search.Name = role.Name;
    search.Description = role.Description;
    search.EmployeeId = role.EmployeeId;    
} 
 public Role GetRoleById(int id)
 {
    var search = roles.Find(x=>x.Id==id);
    return search;
 }
public void Delete(int id)
{
    var search = roles.Find(x=>x.Id==id);
    roles.Remove(search);
}
public int Count()
{
  int search = roles.Count();
  return search;
}
}
