using DependencyInjectionPattern.ConstructorInjection;
using System;
using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class ConstructorInjectionExample
    {
        // Constructor Injection Example

        static void Main()
        {
            BusinessLayer businesslayer = new BusinessLayer(new DataAccessLayer());
            List<Employee> employee = businesslayer.GetAllEmployees();

            foreach (var item in employee)
            {
                Console.WriteLine("Id:{0} \t Name:{1} \t Position:{2} \t office:{3} \t Salary:{4}"
                    , item.Id, item.Name, item.Position, item.Office, item.Salary);
            }
            Console.ReadLine();
        }
    }
}
