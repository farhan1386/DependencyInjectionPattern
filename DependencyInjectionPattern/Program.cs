using System;
using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer businesslayer = new BusinessLayer(new EmployeeDataAccessLayer());
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
