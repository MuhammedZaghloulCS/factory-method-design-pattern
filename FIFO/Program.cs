using System;
namespace FIFO1
{
    class Program
    {
        private static void Main(string[]args)
        {
              
            var em=new EmployeesManagement();

            em.AddEmployee(1,"Muhammed",'m',15000);
            em.AddEmployee(2, "Ahmed", 'm', 13000);
            em.AddEmployee(3, "Mahmoud", 'm', 1000);
            em.PrintEmpolyees();



        }
    } 

}