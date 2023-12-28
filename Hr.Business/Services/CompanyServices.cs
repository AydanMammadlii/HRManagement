using Hr.Business.Interface;
using Hr.Business.Utilities.Exeptions;
using Hr.DataAccess.Contexts;
using HrManagment.Entities;

namespace Hr.Business.Services;

public class CompanyServices : ICompanyServices
{
    public void Create(string? name, string description)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Company? dbCompany=
            HRDbContext.Companies.Find(c=>c.Name.ToLower() == name.ToLower());
        if(dbCompany is not null) 
            throw new AlreadyExistExcepsion($"{dbCompany.Name} is already exist");
        Company company = new(name, description);
        HRDbContext.Companies.Add(company);
    }
    public void Activate(string name, bool isActive = false)
    {
        if(String.IsNullOrEmpty(name))throw new ArgumentNullException();
        Company? dbCompany =
            HRDbContext.Companies.Find(c=>c.Name.ToLower() == name.ToLower());
        if (dbCompany is null)
            throw new NotFoundException($"{name} company is not found");
        dbCompany.IsActive = true;
    }

    public void Delete(string name)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        Company? dbCompany = 
            HRDbContext.Companies.Find(c=> c.Name.ToLower() == name.ToLower());
        if (dbCompany is null)
            throw new NotFoundException($"{name} company is not found");
    }

    public Company GetCompany(int Id)
    {
        throw new NotImplementedException();
    }

    public void GetDepartmentIncluded(string name)
    {
        throw new NotImplementedException();
    }

    public void ShowAll()
    {
        foreach(var company in HRDbContext.Companies)
        {
            Console.WriteLine($"id:{company.Id}; Company Name: {company.Name}");
        }
    }

    public Company? FindCompanyByName(string name)
    {
        if (String.IsNullOrEmpty(name)) throw new ArgumentNullException();
        return HRDbContext.Companies.Find(c => c.Name.ToLower() == name.ToLower());
    }
}
