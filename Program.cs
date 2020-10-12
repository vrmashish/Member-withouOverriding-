using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class Program
    {
        public static void Main()
        {
            Manager managerObj1 = new Manager();
            Employee employeeObj1 = new Employee();
            
            employeeObj1.GetDetails();
            employeeObj1.GetSpecialization();
            employeeObj1.PrintDetails();
            employeeObj1.PrintSalary();
            employeeObj1.PrintSpecialization();

            managerObj1.GetDetails();
            managerObj1.GetDepartment();
            managerObj1.PrintDetails();
            managerObj1.PrintDepartment();
            managerObj1.PrintSalary();
            
        }
    }
}
