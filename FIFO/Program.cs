using System;
namespace FIFO1
{
    class Program
    {
        private static void Main(string[]args)
        {
            /*var x=new EmployeesManagement();
            var em = new Employee1[] {
                new Employee1(1,"Muhammed",'m',15000),
                 new Employee1(2, "Ahmed", 'm', 13000),
                 new Employee1(3, "Mahmoud", 'm', 1000)
            };



           x.ClassifyTheEmployees(em, "less than 5000", (Employee1 em) =>  em.TotalSales < 5000 );
            x.ClassifyTheEmployees(em, "more than 5000", (Employee1 em) => em.TotalSales > 5000);
            */

            Event e = new Event();
            e.ScoreUpdate += (int newScore) => { if (newScore >= 100) Console.WriteLine("Win"); };

            e.Score=0;
            e.Score = 50;

            e.Score = 100;






        }
    } 

}