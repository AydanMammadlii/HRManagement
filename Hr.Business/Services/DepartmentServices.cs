using Hr.Business.Interface;
using Hr.Business.Utilities.Exeptions;
using Hr.DataAccess.Contexts;
using HrManagment.Entities;

namespace Hr.Business.Services;

public class DepartmentServices : IDepartmentServices
{
    private ICompanyServices companyServices { get; }
    public DepartmentServices()
    {
        companyServices = new CompanyServices();
    }
    public void Create(string name, int employeeLimit, int currentEmployeeCount, int companyId, string companyName)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Department? dbDepartment =
            HRDbContext.Departments.Find(c => c.Name.ToLower() == name.ToLower());
        if (dbDepartment is not null)
            throw new AlreadyExistExcepsion($"{dbDepartment.Name} is already exist");
        if (employeeLimit < 4)
            throw new MinCountException("Minimum employee count requirement is 4");
        Company? company = companyServices.FindCompanyByName(companyName);
        if (company is null) throw new NotFoundException($"{companyName} is not exist");
        Department department = new(name, employeeLimit, currentEmployeeCount, companyId, companyName);
        HRDbContext.Departments.Add(department);
    }
  
    public void Activate(string name, bool activated)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        var isDepartment = HRDbContext.Departments.Find(x => x.Name.ToLower() == name.ToLower());
        if (isDepartment is null) throw new NotFoundException($"{name} department is not found");
        isDepartment.IsActive = true;
    }

    public Department? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Department? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Delete(string name)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        var isDepartment = HRDbContext.Departments.Find(x => x.Name.ToLower() == name.ToLower());
        if (isDepartment is null) throw new NotFoundException($"{name} department is not found");
        isDepartment.IsActive = false;
    }

    public void ShowAllEmployee(string name)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        throw new NotImplementedException();
    }

    
}


    