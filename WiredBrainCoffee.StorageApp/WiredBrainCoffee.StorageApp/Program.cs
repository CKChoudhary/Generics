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
            var employeeRepository = new EmployeeRepositoryWithRemove<Employee, int>();
            employeeRepository.Add(new Employee(){FirstName = "test"});
            employeeRepository.Save();
            Console.ReadLine();
        }
    }
}
