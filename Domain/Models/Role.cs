namespace Domain.Models;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int EmployeeId { get; set; }
    
}
