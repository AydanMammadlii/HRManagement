using HrManagment.Entities;

namespace Hr.DataAccess.Contexts;

public static class HRDbContext
{
    public static List<Employee> Employees { get; set; }
    public static List<Department> Departments { get; set; }
    public static List<Company> Companies { get; set; }
}

    

