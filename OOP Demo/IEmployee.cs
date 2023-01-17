using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo
{
    internal interface IEmployee
    {
        public void EmpName();
        public void  Designation();
        public void EmpId();
        public void Age();
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
                    throw new Exception("Please enter Designation of the employee");
                }
                else
                {
                    EmpDesignation = value;
                }
            }
        }
        protected internal abstract void DeptDetail();
    }
}
