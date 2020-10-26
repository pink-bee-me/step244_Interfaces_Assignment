using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using step44_Interface_Assignment;

namespace step244_Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sampleEmployee = new Employee();

            sampleEmployee.FirstName = "Sample";
            sampleEmployee.LastName = "Student";

            sampleEmployee.SayName();
            Console.ReadLine();

            sampleEmployee.Quit();
            Console.ReadLine();
            
            Employee employee = new Employee();

        }

    }
    }

