namespace Infrastructure.Services;
using Domain.Models;
public class ExperienceService
{
    private List<Experience> experiences = new List<Experience>();
   public List<Experience> GetExperiences()
   {
        return experiences;
   }
 public void Add(Experience experience)
{     
    experiences.Add(experience);
} 

public void Update(Experience experience, int id)
{
    var search = experiences.Find(x=>x.Id==id);
    search.Name = experience.Name;
    search.Company = experience.Company;
    search.Description = experience.Description;
    search.EmployeeId = experience.EmployeeId;
} 
 public Experience GetExperienceById(int id)
 {
    var search = experiences.Find(x=>x.Id==id);
    return search;
 }
public void Delete(int id)
{
    var search = experiences.Find(x=>x.Id==id);
    experiences.Remove(search);
}
public int Count()
{
  int search = experiences.Count();
  return search;
}
}
