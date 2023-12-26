using HrManagment.Entities;

namespace Hr.Business.Interface;

public interface ICompanyServices
{
    void Create(string? name, string description);
    void Delete(string name);
    void Activate(string name, bool isActive = false);
    void ShowAll();
    Company GetCompany(int Id);
    void GetDepartmentIncluded(string name);
    Company? FindCompanyByName(string name);
}
