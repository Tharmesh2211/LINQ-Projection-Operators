using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Select_Method
{
    public class EmployeeList
    {
        public static List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Tharmesh" },
            new Employee { EmployeeId = 2, Name = "Gopi" },
            new Employee { EmployeeId = 3, Name = "Parthiban" },
            new Employee { EmployeeId = 3, Name = "Allwyn" }

        };

        public void SelectMethodAll()
        {
            var result = employees.Select(employee => new { employee.EmployeeId, employee.Name });            
            Console.WriteLine("\nAll Employee Information with EmployeeId and Name : \n");
            PrintDetail(result);
        }

        public void SelectMethodSpecific()
        {
            var result1 = employees
           .Where(employee => employee.EmployeeId == 3)
           .Select(employee => new { employee.EmployeeId, employee.Name });

            if(result1.Count() > 0)
            {
                Console.WriteLine("\nSpecific Employee Information with EmployeeId and Name : \n");
                PrintDetail(result1);
            }
        }

        public void SelectQueryAll()
        {
            Console.WriteLine("\nUsing Select All Query : \n");
            var result = from employee in employees
                         select new { EmpId = employee.EmployeeId, EmpName = employee.Name};

                                                //OR select employee;
            foreach (var employee in result)
            {
                Console.WriteLine($"EmployeeId: {employee.EmpId}, Name: {employee.EmpName}");
            }
        }

        public void SelectQuery()
        {
            Console.WriteLine("\nUsing Select Query : \n");
            var result = from employee in employees
                         where employee.EmployeeId == 3
                         select new { EmpId = employee.EmployeeId, EmpName = employee.Name };

            //OR select employee;
            foreach (var employee in result)
            {
                Console.WriteLine($"EmployeeId: {employee.EmpId}, Name: {employee.EmpName}");
            }
        }
        public void PrintDetail(IEnumerable<dynamic> result)
        {
            foreach (var employee in result)
            {
                Console.WriteLine($"EmployeeId: {employee.EmployeeId}, Name: {employee.Name}");
            }
        }

    }
    
}
