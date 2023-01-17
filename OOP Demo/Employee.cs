namespace OOP_Demo
{
    public class Employee
    {
        private float _salary;

        public Employee(float salary)
        {
            this._salary = salary;
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Details of the Employee are following there : ");
            Console.WriteLine("Salary : " + _salary);
        }

        public static class CompanyDetail
        {
            public static string Company = "Simform Solutions";
            public static void GetCompanyName()
            {
                Console.WriteLine("Company Name :" + Company);
            }
        }
        
        public static void Main(string[] args)
        {
            Employee emp = new Employee(25000);
            emp.GetEmployeeDetails();
            Details details = new Details();
            CompanyDetail.GetCompanyName();
            details.EmpId();
            details.EmpName();
            details.Age();
            details.Designation();
            details.DeptName = "Asp.Net";
            details.DeptDetail();
        }
    }
}
