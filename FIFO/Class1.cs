using System;
namespace FIFO1
{
    class Employee
    {
        private char gender;
        private Employee(int id,string name,char gender,decimal totalSales)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.TotalSales = totalSales;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { 
            get{
                return gender;

            }
            set
            {
                if (value == 'm' || value == 'f' || value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Unkown Gender");
            }
        }
        public decimal TotalSales { get; set; }

        public static Employee newEmployee(int id,string name,char gender,decimal totalSales)
        {
            return new Employee(id,name,gender,totalSales);
        }
    }

    class EmployeesManagement

    {
        public delegate bool classificationOfEmployees(Employee1 e);
        private List<Employee> employees;
        public EmployeesManagement()
        {
            employees = new List<Employee>();
        }
        public void AddEmployee(int id, string name, char gender, decimal totalSales) => employees.Add(Employee.newEmployee(id, name, gender, totalSales));
        public void PrintEmpolyees()
        {
            foreach (Employee em in employees)
            {
                Console.WriteLine($"ID: {em.Id}, Name: {em.Name}, Total Sales:{em.TotalSales}");
            }
        }

        public void ClassifyTheEmployees(Employee1[] emps, string title, classificationOfEmployees dele)
        {
            Console.WriteLine(title + "\n" + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var emp in emps)
            {
                if (dele(emp))
                {
                    Console.WriteLine($"Name:{emp.Name}, Gender:{emp.Gender}, TotalSales: {emp.TotalSales}");
                }

            }
            Console.WriteLine("\n\n");

        }
    }
}
class Employee1
{
    private char gender;
    public Employee1(int id, string name, char gender, decimal totalSales)
    {
        this.Id = id;
        this.Name = name;
        this.Gender = gender;
        this.TotalSales = totalSales;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public char Gender
    {
        get
        {
            return gender;

        }
        set
        {
            if (value == 'm' || value == 'f' || value == 'M' || value == 'F')
                gender = value;
            else
                throw new ArgumentException("Unkown Gender");
        }
    }
    public decimal TotalSales { get; set; }

   
}
