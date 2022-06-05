using Consoletask_04._06._2022.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletask_04._06._2022
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public Employee[] Employees;
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }

        public Department() { }
        public Department(string name, int employeeLimit, int budget,bool isbach) :this()
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Budget = budget;
            IsBachelorDegreeRequired = isbach;
        }
        public bool AddEmployee(Employee emp) 
        { if (emp.Experience >= RequiredExperience && emp.HasBachelorDegree == IsBachelorDegreeRequired)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = emp;
                int sum = 0;
                foreach (var item in Employees)
                {
                    sum += emp.Salary;
                }
                if (EmployeeLimit >= Employees.Length && Budget >= sum) 
                {
                    return true;
                }
            }
            return false;
        }
        public void AvarageSalary() 
        {
            int total = 0;
            foreach (var item in Employees)
            {
                total += item.Salary;
            }
            int count = Employees.Length;
            Helper.Printer($"Avarage salary = {total / count}", ConsoleColor.Cyan);
        }
    }
}
