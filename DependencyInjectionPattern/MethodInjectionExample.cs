using DependencyInjectionPattern.MethodInjection;
using System;
using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class MethodInjectionExample
    {
        // Method Injection Example

        static void Main()
        {
            BusinessLayer employee = new BusinessLayer();

            List<Employee> employees = employee.GetAllEmployees(new DataAccessLayer());
            foreach (var item in employees)
            {
                Console.WriteLine("Id:{0} \t Name:{1} \t Position:{2} \t office:{3} \t Salary:{4}"
                    , item.Id, item.Name, item.Position, item.Office, item.Salary);
            }
            Console.ReadKey();
        }
    }
}
