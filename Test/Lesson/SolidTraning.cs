using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lesson
{
    public class SolidTraning
    {

    }

    public class Employee
    {
        public string Name { get; set; }
        public IEmployeeType EmployeeType { get; set; }

        public Employee(string name, IEmployeeType employeeType)
        {
            Name = name;
            EmployeeType = employeeType;
        }

        public decimal CalculateSalary()
        {
            return EmployeeType.GetEmployeeSalary();
        }
    }

    public interface IEmployeeType
    {
        decimal GetEmployeeSalary();
    }

    public class FullTime : IEmployeeType
    {
        public decimal GetEmployeeSalary()
        {
            return 5000m;
        }
    }

    public class PartTime : IEmployeeType
    {
        public decimal GetEmployeeSalary()
        {
            return 3000m;
        }
    }

    public class Intern : IEmployeeType
    {
        public decimal GetEmployeeSalary()
        {
            return 1000m;
        }
    }
}
