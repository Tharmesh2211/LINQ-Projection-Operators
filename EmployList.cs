using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class EmployList
    {

        List<Employee> emp = new List<Employee>() {
            new Employee() {Emp_Id = 209, Emp_Name = "Anjita", Emp_Gender = "Female", Emp_Date = "12/3/2017", Emp_Salary = 20000, Emp_Lang = new List<string>{"C#", "VB"} },
                new Employee() {Emp_Id = 210, Emp_Name = "Soniya", Emp_Gender = "Female", Emp_Date = "22/4/2018", Emp_Salary = 30000, Emp_Lang = new List<string>{ "Java"} },
                new Employee() {Emp_Id = 211, Emp_Name = "Rohit", Emp_Gender = "Male", Emp_Date = "3/5/2016", Emp_Salary = 40000, Emp_Lang = new List<string>{ "C++", "SQL"} },
                new Employee() {Emp_Id = 212, Emp_Name = "Supriya", Emp_Gender = "Female", Emp_Date = "4/8/2017", Emp_Salary = 40000, Emp_Lang = new List<string>{"Python", "C", "PHP"} },
                new Employee() {Emp_Id = 213, Emp_Name = "Anil", Emp_Gender = "Male", Emp_Date = "12/1/2016", Emp_Salary = 40000, Emp_Lang = new List<string>{"HTML", "JQuery"} },
                new Employee() {Emp_Id = 214, Emp_Name = "Anju", Emp_Gender = "Female", Emp_Date = "17/6/2015", Emp_Salary = 50000, Emp_Lang = new List<string>{"JavaScript", "Perl"} },
            };


        // 11111111111111111

        public void SelectManySpecificValue()
        {
            Console.WriteLine("\nSelect Specific Value with Select Many Query : \n");
            var res = from e in emp
                      from e2 in e.Emp_Lang
                      select new { EmpID = e.Emp_Id, Language = e2 };


            Console.WriteLine("Languages known by all the employees are:");
            foreach (var val in res)
            {
                Console.WriteLine(val.EmpID + "   " + val.Language);
            }
            Console.WriteLine("=================================");

        }



        //222222222222222222

        public void SelectManyQuery()
        {
            var res1 = from e in emp
                       from e2 in e.Emp_Lang
                       select e2;

            Console.WriteLine("Languages known by all the employees are:");
            foreach (var val in res1)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("=================================");
        }

        //333333333333333333

        public void SelectManyMethod()
        {
            Console.WriteLine("\nPrint Specific Value using SelectMany Method : \n");
            var res2 = emp.SelectMany(a => a.Emp_Lang, (a, lang) => new { EmpID = a.Emp_Id, Name = a.Emp_Name, Gender = a.Emp_Gender, Language = lang });
            Console.WriteLine("\nLanguages known by all the employees are:\n");
            foreach (var val in res2)
            {
                Console.WriteLine(val.EmpID + "     " + val.Name + "        " + val.Language);
            }
            Console.WriteLine("=================================");
        }

    }
}
