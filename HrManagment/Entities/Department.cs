﻿using HrManagment.Interface;

namespace HrManagment.Entities;

public class Department : IEntity
{
    public int Id { get; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public bool IsActive { get; set; }
    public int CompanyId { get; set; }
    private static int _id;
    public Department(string name, int employeeLimit, int companyId)
    {
        Id = _id++;
        Name = name;
        EmployeeLimit = employeeLimit;
        CompanyId = companyId;
    }
}