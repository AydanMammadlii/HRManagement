﻿namespace Hr.Business.Interface;

public interface IEmployeeServices
{
    void Create(string name, string surname, string email, 
        string password, string departmentName, decimal Salary, int departmentId);
    void Delete(int Id);
    void ChangeDepartment(int employeeId, string newDepartmentName);

}
