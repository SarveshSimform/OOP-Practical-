using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    internal interface IEmployee
    {
        public void GetEmployeeId();
        public void GetEmployeeAge();
        public void GetEmployeeName();
        public void GetEmployeeDesignation();
    }
    public abstract class DeptDetails
    {
        protected internal string? DeptName;
        protected internal string? EmpDesignation;
        protected internal string empDesignation
        {
            get
            {
                return EmpDesignation;
            }
            set
            {
                if (EmpDesignation != null)
                {
                    throw new Exception("Please enter GetEmployeeDesignation of the employee");
                }
                else
                {
                    EmpDesignation = value;
                }
            }
        }
        internal abstract void DeptDetail();
    }
}
