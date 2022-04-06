using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Employee
    {
        private int _id;
        private string _workerName;
        private string _workerSurName;
        private decimal _salary;
        private EmployeeType _employeeType;
        
        public Employee(int id,string wokerName, string workerSurName, decimal salary,EmployeeType employeeType)
        {
            _id = id;
            _workerName = wokerName;
            _workerSurName = workerSurName;
            _salary = salary;
            _employeeType = employeeType;
        }

        public string WorkerName { get => _workerName; set => _workerName = value; }
        public string WorkerSurName { get => _workerSurName; set => _workerSurName = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public EmployeeType EmployeeType { get => _employeeType; set => _employeeType = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"Worker ID` {_id} , Worker Name` {_workerName} ,SurName ` {_workerSurName} , Salary ` {_salary} AMD , Employee Type ` {_employeeType}";
        }
    }
}
