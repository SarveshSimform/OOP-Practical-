using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    public class EmployeeDetails : DeptDetails, IEmployee
    {
        public void GetEmployeeId()
        {
            Console.WriteLine("Details of the Employee are following there : ");
            Console.WriteLine("EmployeeId : 2089");
        }
        public void GetEmployeeAge()
        {
            Console.WriteLine("Employee Age : 22");

        }
        public void GetEmployeeDesignation()
        {
            Console.WriteLine("Employee Designation : Software Engineer");
        }


        public void GetEmployeeName()
        {
            Console.WriteLine("Employee Name : Sarvesh Patel");
        }

        internal override void DeptDetail()
        {
            Console.WriteLine("Department Name :" + DeptName);
        }
    }
}
