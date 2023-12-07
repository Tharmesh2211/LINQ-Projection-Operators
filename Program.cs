using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // It Execute the class which is inside the folder

           Select_Method.EmployeeList employee = new Select_Method.EmployeeList();
            employee.SelectQuery();
            employee.SelectQueryAll();
            employee.SelectMethodAll();
            employee.SelectMethodSpecific();

            // It Execute the class which is outside the Folder
            Console.WriteLine("\n************************************************************************\n");
            EmployList employList = new EmployList();
            employList.SelectManySpecificValue();
            employList.SelectManyQuery();
            employList.SelectManyMethod();
        }
    }
}
