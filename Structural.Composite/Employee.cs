using System.Collections.Generic;

namespace Structural.Composite
{
    /// <summary>
    /// Step 1 - Create Employee class having l ist of Employee objects
    /// </summary>
    public class Employee
    {
        private readonly string _name;
        private readonly string _dept;
        private readonly int _sal;
        private readonly List<Employee> _subordinates;

        public Employee(string name, string dept, int sal)
        {
            _name = name;
            _dept = dept;
            _sal = sal;
            _subordinates = new List<Employee>();
        }

        public void Add(Employee e)
        {
            _subordinates.Add(e);
        }

        public void Remove(Employee e)
        {
            _subordinates.Remove(e);
        }

        public List<Employee> GetSubordinates()
        {
            return _subordinates;
        }

        public string GetEmployeeInfo()
        {
            return "Employee: [ Name: " + _name + ", Dept: " + _dept + ", Salary: " + _sal + "]";
        }
    }
}