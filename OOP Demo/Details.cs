using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    public class Details : DeptDetails, IEmployee
    {
        public void Age()
        {
            Console.WriteLine("Age : 22");
        }
        public void Designation()
        {
            Console.WriteLine("Designation : Software Engineer");
        }

        public void EmpId()
        {
            Console.WriteLine("EmpId : 2089");
        }

        public void EmpName()
        {
            Console.WriteLine("Name : Sarvesh Patel");
        }
        protected internal override void DeptDetail()
        {
            Console.WriteLine("Department Name :" + DeptName);
        }
    }
}
