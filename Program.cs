using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using step244_Interface_Assignment;
using step244_Interfaces_Assignment;

namespace step244_Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable sampleEmployee = new Employee();

            this.FirstName = "Sample";
            sampleEmployee.lastName = "Student";

            sampleEmployee.SayName();
            Console.ReadLine();

            sampleEmployee.Quit();
            Console.ReadLine();
        

            Employee employee = new Employee();

            employee.CreateEmployeeID();
            Console.ReadLine();

            employee.EmployeeDateOfEntry();
            Console.ReadLine();

            employee.SayName();
            Console.ReadLine();

            employee.Quit();
            Console.ReadLine();

        }

    }
    }

