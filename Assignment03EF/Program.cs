using Assignment03EF.Context;
using Assignment03EF.Entites;

namespace Assignment03EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using Test2DbContext dbContext = new Test2DbContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                Name = "Fatma",
                Age = 23,
                Salary = 20.000M,
                StartDate = DateTime.Now
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                Name = "Ahmed",
                Age = 25,
                Salary = 30.000M,
                CountOfHours = 20,
                HourRate = 100 
            };
            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.partTimeEmployees.Add(partTimeEmployee);
            //dbContext.SaveChanges();

            var Employees = from EMP in dbContext.Employees
                             select EMP;

            foreach (var item in Employees.OfType<FullTimeEmployee>())
                Console.WriteLine(item.Name);
            foreach (var item in Employees.OfType<PartTimeEmployee>())
                Console.WriteLine(item.Name);


        }
    }
}
