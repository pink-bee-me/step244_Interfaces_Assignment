using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step244_Interfaces_Assignment
{
    interface IUserInput
    { 
        void EnterEmployee()
            {
                Console.WriteLine("Entry Status: (Enter 1 for \"new\"; 2 for \"existing\")");
                string employeeStatus = Console.ReadLine();

                Console.WriteLine("Enter Fist Name: ");
                string firstName = Console.ReadLine();


                Console.WriteLine("Enter Last Name: ");
                string lastName = Console.ReadLine();
            }

        }
    }
}
}
