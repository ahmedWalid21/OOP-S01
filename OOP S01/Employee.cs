using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S01
{
    internal struct Employee
    {
       private int id;
        private string name;
        private double salary;

        public void setId(int id)
        {
            this.id = id;
        }
        //getter
        public int getId()
        {
            return id;
        }

        public void setName(string name)
        {
            if(name.Length>8 && name.Length<20)
            this.name = name;   
        }

        public string getName()
        {
            return name;
        }
         public void setSalary(double salary)
        {
            if(salary>0)
            this.salary = salary;
        }
        public double getSalary()
        {
            return salary;
        }

       public Employee(int id, string name, double salary)
        {
            setId(id);
            setName(name);  
            setSalary(salary);

        }

        public override string ToString()
        {
            return $"id= {id}:: name= {name} :: salary={salary}";
        }



    }
}
