using Hr.Business.Interface;
using Hr.Business.Utilities.Exeptions;
using Hr.DataAccess.Contexts;
using HrManagment.Entities;

namespace Hr.Business.Services;

public class EmployeeServices : IEmployeeServices
{
    private IDepartmentServices departmentServices { get; }
    public EmployeeServices()
    {
        departmentServices = new DepartmentServices();
    }
    public void Create(string name, string surname, string email, string password,
        string departmentName, decimal salary, int departmentId)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Department? department = departmentServices.GetByName(departmentName);
        if (department is null) throw new NotFoundException($"{departmentName} is not exist");
        Employee employee = new(name, surname, email, password, salary, departmentId );
        HRDbContext.Employees.Add( employee );
    }
    public void ChangeDepartment(int employeeId, string newDepartmentName)
    {
        throw new NotImplementedException();
    }
    public void Delete(int Id)
    {
        throw new NotImplementedException();
    }
    public void ShowAll()
    {
        foreach (var employee in HRDbContext.Employees)
        {
            Console.WriteLine($"Id: {employee.Id}; Department name: {employee.Name}");
        }
    }
}
