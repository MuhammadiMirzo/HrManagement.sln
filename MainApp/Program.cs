using Domain.Models;
using Infrastructure.Services;
var emp = new EmployeeService();
var department1 = new Department(){
    Id = 1,
    Name = "IT"
};
var department2 = new Department(){
    Id = 2,
    Name = "HR"
};
var department3 = new Department(){
    Id = 3,
    Name = "Accounting"
};
var experience1 = new Experience(){
    Id = 1,     
    Company = "Alif",

};
var experience2 = new Experience(){
    Id = 2,  
    Company = "Mohir",

};
var role1 = new  Role(){
    Id = 1,
    Name = "user"
};
var role2 = new  Role(){
    Id = 1,
    Name = "it"
};
var emplyees = new List<Employee>();   // list of employees
var em1 = new Employee()               // first employee
{
    FirstName = "Nurullo",
    LastName = "Sulaymonov",
    Department = department1,
    Experience = {experience1,experience2},
    Roles = {role2,role1}
};
emplyees.Add(em1);                    // adding first employee to list of employees

var em2 = new Employee()             // second employee
{
    FirstName = "Azim",
    LastName = "Aymonov",
    // Department = department2,
    // Experience = {experience2,experience1},
    // Roles  = {role1,role2}
};
emplyees.Add(em2);                    // adding second employee to the list of employees

var em3 = new Employee()              // third employee
{
    FirstName = "Saif",
    LastName = "Fayzov",
    Department = department1,
    // Experience = {experience1,experience2},
    // Roles = {role2,role1}
};
emplyees.Add(em3);                  // adding third employee to list of employees

var em4 = new Employee()            // fourth employee
{
    FirstName = "Ali",
    LastName = "Girov",
    Department = new Department(),
    // Experience = {experience2,experience1},
    // Roles = {role1,role2,role1}
};
emplyees.Add(em4);                  //adding 4th employee to list

var  em5 = new Employee()            // 5th employee 
{
    FirstName = "Hirot",
    LastName = "Donov",
    Department = department1,
};
emplyees.Add(em5);                    // adding 5th employee to list
foreach (var item in emplyees)
{
    var dep = item.Department;
}
foreach (var item in emplyees)
{
    System.Console.WriteLine(item.FirstName+" "+item.LastName+" "+);
}




// Create 5 Employees, each employee should have 2 roles (user, hr, it, accounting). Each
// Employee should have department. Employees should have at least 2 experiences.
// Using foreach print Every Employee
// Output : 
// Nurullo Sulaymonov
// Department : IT
// Experiences : Alif, Mohir
// Roles : user, IT
