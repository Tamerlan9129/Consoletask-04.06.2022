using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletask_04._06._2022
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public bool HasBachelorDegree { get; set; }

        public Employee()
        {

        }
        public Employee(string name, string surname, int salary, int experience, bool hasbachelor):this()
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            Experience = experience;
            HasBachelorDegree = hasbachelor;
        }
        
    }
}
