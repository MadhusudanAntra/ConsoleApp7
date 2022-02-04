using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class ManageEmployee
    {
        EmployeeRepository employeeRepository;
        public ManageEmployee()
        {
            employeeRepository = new EmployeeRepository();
        }

        public void PrintEmployee()
        {
            IEnumerable<Employee> employees = employeeRepository.GetDataByCondition(  x => x.City == "Sterling" );
            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.Name}\t {item.Department} \t {item.State} \t {item.City}");
            }
        }
        
    }
}
