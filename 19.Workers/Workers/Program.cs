using System;

namespace Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1,"Ani","Galstyan",120000,EmployeeType.MiddleBackEndDeveloper);
            Employee employee1 = new Employee(2,"Vazgen", "Abrahamyan", 200000,EmployeeType.SeniorBackEndDeveloper);
            Company company = new Company(10);
            Company company1 = new Company(10);
            company.AddEmployee(employee);
            company.AddEmployee(employee1);
            company.ShowEmployeesInformation();
            company.RemoveEmployee(employee.Id);
            company.ChangeSalary(employee1.Id,250000);
            company.ChangeEmpType(EmployeeType.SeniorBackEndDeveloper, employee1.Id);
            company.ChangeCompany(company, company1, employee1);
        }
        
    }
}
