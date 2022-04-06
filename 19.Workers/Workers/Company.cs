using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Company
    {
        
        public Company(int length)
        {
            workers = new Employee[length];
        }
        Employee[] workers;
        int index = 0;
        public Employee this[int i]
        {
            get { return workers[i]; }
            set { workers[i] = value; }
        }
        public void AddEmployee(Employee employee)
        {
            if (index < workers.Length)
            {

                if (workers[index] == null)
                {
                    workers[index] = employee;
                }
                else
                {
                    Console.WriteLine("Employee exist in this position.");
                }
                index++;
            }
            else
            {
                Console.WriteLine("Sorry we can not have  more then 10 employees");
            }
        }
        public void RemoveEmployee(int id)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] != null)
                {
                    if (workers[i].Id == id)
                    {
                        Console.WriteLine("Employee fired \n{0}", workers[i]);

                        workers[i] = null;

                        break;
                    }
                }
            }
        }
        public void ShowEmployeesInformation()
        {
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine(workers[i]);
            }
        }
        public void ChangeSalary(int id, decimal salary)
        {
            Employee foundEmployee = FindEmployee(id);
            if (foundEmployee != null)
            {
                Console.WriteLine("Old Salary`{0}", foundEmployee.Salary);

                foundEmployee.Salary = salary;

                Console.WriteLine(foundEmployee);
            }
            else
                Console.WriteLine("Employee not found.");
        }
        public Employee FindEmployee(int id)
        {
            Employee foundEmployee = null;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i] != null)
                {
                    if (workers[i].Id == id)
                    {
                        foundEmployee = workers[i];
                        break;
                    }
                }
            }
            return foundEmployee;
        }
        public void ChangeEmpType(EmployeeType empType, int id)
        {
            Employee foundEmployee = FindEmployee(id);

            if (foundEmployee != null)
            {
                Console.WriteLine($"{foundEmployee} where Employee type `{foundEmployee.EmployeeType}");
                foundEmployee.EmployeeType = empType;
                Console.WriteLine(foundEmployee);
            }

            else Console.WriteLine("Employee not found.");
        }
        public  void ChangeCompany(Company company, Company company1, Employee employee)
        {
            company1.AddEmployee(employee);
            company.RemoveEmployee(employee.Id);
        }

    }
}
