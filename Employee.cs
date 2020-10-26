using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using step244_Interface_Assignment;
using step244_Interfaces_Assignment;

namespace step44_Interface_Assignment
{
   public class Employee : Person, IQuittable, IUserInput

    {
        public Employee()
        {
        Console.WriteLine("This is a Demo.");
        }

        

        public void EmployeeEntry()
        {
            Console.WriteLine("Employee Status: (Enter 1 for \"new\"; 2 for \"existing\")");
            string employeeStatus = Console.ReadLine();
            var entryDate = DateTime.Now;
            string dateActive = Convert.ToString(entryDate);

            Console.WriteLine("Enter Employee Fist Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name: ");
            string lastName = Console.ReadLine();

        public List<string> ActiveEmployeeList = new List<string>(firstName, lastname, dateActive);
            if (employeeStatus = "1")
            {


            }
       public string FirstName = 

       public string FirstName1
       {
           get => ;
           set => FirstName = value;
       }
    }
        
        public override void SayName()
        {
            Console.WriteLine("You have added a new Person Object to the Employee Class.");
            base.SayName();
            
        }

        public void Quit()
        {
            Console.WriteLine("Is " + FirstName + " " + LastName +
                              " a current employee?\n Enter 1 for \"yes\" or 2 for \"no\"");
            string trueOrFalse = Console.ReadLine();
            if (trueOrFalse == "1")
            {
                string activeEmployee = "Employee Status : Active";
                Console.WriteLine(activeEmployee);

            }
            else
            {
                Console.WriteLine("Employee Status: Not Active");
            }

            Console.ReadLine();
        }
    }
}
