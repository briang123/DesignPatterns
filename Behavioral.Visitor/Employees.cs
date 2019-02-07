﻿using System;
using System.Collections.Generic;

namespace Behavioral.Visitor
{
    public class Employees
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var e in _employees)
            {
                e.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}