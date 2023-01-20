using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    public class Manager : IEmployee
    {
        public void GetEmployeeId()
        {
            Console.WriteLine("Details of the Manager are following there : ");
            Console.WriteLine("EmployeeId : 3078");
        }
        public void GetEmployeeAge()
        {
            Console.WriteLine("Employee Age : 30");

        }
        public void GetEmployeeDesignation()
        {
            Console.WriteLine("Employee Designation : Technical Project Manager");
        }
        public void GetEmployeeName()
        {
            Console.WriteLine("Employee Name : Kevin Battista ");
        }
        public void GetManagerProject()
        {
            Console.WriteLine("Manager Project : Global Beta");
        }

    }
}
