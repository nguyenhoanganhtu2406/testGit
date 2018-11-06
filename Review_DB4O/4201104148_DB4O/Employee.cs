using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4201104148_DB4O
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Skill { get; set; }
        public Company HomeBase { get; set; }
        public Employee Manager { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string fullName, string skill, Company homeBase, double salary, Employee manager = null)
        {
            ID = id;
            FullName = fullName;
            Skill = skill;
            HomeBase = homeBase;
            Salary = salary;
            Manager = manager;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} ({2})", FullName, Skill, Salary);
        }
    }
}
