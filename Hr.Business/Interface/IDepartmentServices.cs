using HrManagment.Entities;

namespace Hr.Business.Interface;

public interface IDepartmentServices
{
    void Create (string name, int employeeLimit, int companyId, string companyName);
    Department? GetById (int id);
    Department? GetByName (string name);
    void Activate(string name, bool activated);
    void Delete(string name);
    void ShowAllEmployee(string name);
    void ShowAll();
}
