using System;
namespace FIFO1
{
    class Program
    {
        public static void Main()
        {
            Manager manager = new Manager { 
                ID= 1,
                LoggedHours = 180,
                Name="Muhammed",
                Wage=200
            };
            Maintenance maintenance = new Maintenance
            {
                ID = 1,
                LoggedHours = 180,
                Name = "Muhammed",
                Wage = 200
            };
            Sales sales = new Sales
            {
                ID = 1,
                LoggedHours = 180,
                Name = "Muhammed",
                Wage = 200
            };
            Developer Dev = new Developer
            {
                ID = 1,
                LoggedHours = 180,
                Name = "Muhammed",
                Wage = 200
            };
            Console.WriteLine( manager.ToString());
            Console.WriteLine(maintenance.ToString());
            Console.WriteLine(Dev.ToString());
            Console.WriteLine(sales.ToString());
        }
    }
}