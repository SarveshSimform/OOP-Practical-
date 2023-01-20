namespace OOP_Demo
{
    public class Employee
    {
        private float _salary;

        public Employee(float salary)
        {
            this._salary = salary;
        }

        public void GetEmployeeSalary()
        {
            
            Console.WriteLine("Salary : " + _salary);
        }

        public static class CompanyDetail
        {
            public static string Company = "Simform Solutions";
            public static string Address = " 5th Floor, 501 Binori Bsquare2 Nr Double Tree By Hilton, Ambli Rd, Bopal, Ahmedabad, Gujarat";
            public static void GetCompanyDetail()
            {
                Console.WriteLine("Details of the Company are following there : ");
                Console.WriteLine("Company Name :" + Company);
                Console.WriteLine("Address :" + Address + "\n");
            }
        }
        public static void Main(string[] args)
        {
            CompanyDetail.GetCompanyDetail();

            EmployeeDetails details = new EmployeeDetails();
            details.GetEmployeeId();
            details.GetEmployeeName();
            details.GetEmployeeAge();
            details.GetEmployeeDesignation();
            details.DeptName = "Asp.Net";
            details.DeptDetail();

            Employee emp = new Employee(25000);
            emp.GetEmployeeSalary();

            Manager manager = new Manager();
            manager.GetEmployeeId();
            manager.GetEmployeeName();
            manager.GetEmployeeAge();
            manager.GetEmployeeDesignation();
            manager.GetManagerProject();
            Employee managerSalary = new Employee(70000);
            managerSalary.GetEmployeeSalary();
        }
    }
}
