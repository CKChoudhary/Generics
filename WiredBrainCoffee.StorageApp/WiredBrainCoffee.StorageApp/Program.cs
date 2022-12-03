using System;
using System.Runtime.Intrinsics.Arm;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repositories;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var employeeRepository = new ListRepository<Employee>();
            AddEmployee(employeeRepository);
            GetEmployeeById(employeeRepository);
            Console.ReadLine();
        }


        private static void GetEmployeeById(IRepository<Employee> employeeRepository)
        {
            var employee = employeeRepository.GetById(2);
            Console.WriteLine(employee.FirstName);
        }
        private static void AddEmployee(IRepository<Employee> employeeRepository)
        {
           
            employeeRepository.Add(new Employee() { FirstName = "test1" });
            employeeRepository.Add(new Employee() { FirstName = "test2" });
            employeeRepository.Add(new Employee() { FirstName = "test3" });
            employeeRepository.Save();
        }
    }
}
