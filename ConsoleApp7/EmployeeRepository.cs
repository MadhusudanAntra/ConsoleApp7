using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Department { get; set; }
    }
    class EmployeeRepository
    {
        List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee> {

                new Employee(){Id=1, Name="Smith", City="Sterling",State="VA", Department="IT" },
            new Employee(){Id=2, Name="Jane", City="Sterling",State="VA", Department="QA" },
new Employee(){Id=3, Name="Adam", City="Chicago",State="IL", Department="HR" },
new Employee(){Id=4, Name="Olivia", City="Chicago",State="IL", Department="IT" },
new Employee(){Id=5, Name="Olivia", City="Dallas",State="TX", Department="HR" },
new Employee(){Id=6, Name="Willaim", City="Dallas",State="TX", Department="QA" },

            };
           
        }
        public IEnumerable<Employee> GetDataByCondition(Predicate<Employee> del)
        { 
         List<Employee> result= new List<Employee> ();
            foreach (Employee item in employees)
            {
                if (del(item))
                {
                    result.Add(item);
                }
            }
            
            return result;
        }
        
    }
}
