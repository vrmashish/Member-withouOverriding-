using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Member
{
    class Member
    {


        string name;
        int age;
        string phoneNumber;
        string address;
        double salary;


        public void PrintSalary()
        {
            Console.WriteLine("The Salary is {0}", salary);
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());


        }
        public void PrintDetails()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("PhoneNumber: {0}", phoneNumber);
            Console.WriteLine("Adress: {0}", address);
        }
    }
    class Employee:Member
    {
        string specialization;
        public void GetSpecialization()
        {
            Console.WriteLine("Enter Specialization");
            specialization=Console.ReadLine();
        }

        public void PrintSpecialization()
        {
            Console.WriteLine("Specialization: {0}",specialization);
            
        }
    }
    class Manager : Member
    {
         string department;

        public void GetDepartment()
        {
            Console.WriteLine("Enter Department Name: ");
            department = Console.ReadLine();
        }
        public void PrintDepartment()
        {
            Console.WriteLine("Department: {0}", department);

        }
    }
}
