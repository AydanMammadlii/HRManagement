using Hr.Business.Interface;
using Hr.Business.Services;
using Hr.Business.Utilities.Helpers;
using Hr.DataAccess.Contexts;

Console.WriteLine("HR App Start");
CompanyServices companyServices = new();
EmployeeServices employeeServices = new();
DepartmentServices departmentServices = new();
bool isContinue = true;
while (isContinue)
{
    Console.WriteLine("Choose the option:");
    Console.WriteLine("-- Company--\n" +
                      "1 - Create Company \n" +
                      "2 - Show All Company \n" +
                      "3 - Activate Company \n" +
                      "4 - Delete Company \n" +
                      "5 - Get Company Department\n" +

                      "-- Department--\n" +
                      "6 - Create Department \n" +
                      "7 - Show All Department \n" +
                      "8 - Activate Department \n" +
                      "9 - Delete Department \n" +
                      "10 - Get Department Employee \n" +

                      "-- Employee--\n" +
                      "11 - Create Employee \n" +
                      "12 - Show All Employee \n" +


                      "13 - Get Company \n" +
                      "14 - Move Employee \n" +
                      "0 - Exit");

   
}
