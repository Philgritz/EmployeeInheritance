using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance {
    public class Employee : Program {

        public string Name { get; set; }
        public string Job { get; set; }
        public decimal Salary { get; set; }
    }
    public string Print() {
        return $"{this.GetType().Name}:: Name: {Name}, Job: {Job}, Salary: {Salary.ToString("C")};
    }
    public Employee(string name, string job, decimal salary) {
        this.Name = name;
        this.Job = job;
        this.Salary = salary;
    }