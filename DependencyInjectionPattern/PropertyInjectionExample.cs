using DependencyInjectionPattern.PropertyInjection;
using System;
using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class PropertyInjectionExample
    {
        // Property Injection Example

        static void Main(string[] args)
        {
            PropertyBusinessLayer businesslayer = new PropertyBusinessLayer();
            businesslayer.dataAccessObject = new DataAccessLayer();
            List<Employee> emp = businesslayer.GetAllEmployees();

            foreach (var item in emp)
            {
                Console.WriteLine("Id:{0} \t Name:{1} \t Position:{2} \t office:{3} \t Salary:{4}"
                    , item.Id, item.Name, item.Position, item.Office, item.Salary);
            }
            Console.ReadLine();
        }
    }
}
