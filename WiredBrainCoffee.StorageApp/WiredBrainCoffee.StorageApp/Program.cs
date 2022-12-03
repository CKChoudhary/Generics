using System;
using System.Runtime.Intrinsics.Arm;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);
            Console.ReadLine();
        }


        private static void GetEmployeeById(GenericRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine(employee.FirstName);
        }
        private static void AddEmployee(GenericRepository<Employee> employeeRepository)
        {
           
            employeeRepository.Add(new Employee() { FirstName = "test1" });
            employeeRepository.Add(new Employee() { FirstName = "test2" });
            employeeRepository.Add(new Employee() { FirstName = "test3" });
            employeeRepository.Save();
        }
    }
}
