using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal class Employeee
    {
        private int id;
        private string name;
        private char gender;
        private SecurityLevel sl;
       private double salary;
        private HiringDate hd;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }
        public SecurityLevel Sl { get; set; }
        public double Salary { get; set; }
        public HiringDate Hd { get; set; }

        public Employeee(int id, string name, char gender, SecurityLevel sl, double salary, HiringDate hd)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Sl = sl;
            Salary = salary;
            Hd = hd;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Level: {Sl}, Salary: {String.Format("{0:C}", Salary)}, Hire Date: {Hd}";
        }

    }
}
