using HrManagment.Interface;

namespace HrManagment.Entities;

public class Employee : IEntity
{
    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string departmentName { get; set; }
    public decimal Salary { get; set; }
    public bool IsDelete { get; set; }
    public int DepartmentId { get; set; }
    private static int _id;
    public Employee(string name, string surname, string email, string password, decimal salary, int departmentId)
    {
        Id = _id++;
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        Salary = salary;
        IsDelete = false;
        DepartmentId = departmentId;
    }
}