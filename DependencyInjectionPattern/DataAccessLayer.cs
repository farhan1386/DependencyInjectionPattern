using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class DataAccessLayer : IDataAccessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Frahan Ahmed", Position = "Software Developer", Office = "Bangalore", Salary = 80000 });
            employees.Add(new Employee() { Id = 1, Name = "Irfan Ahmed", Position = "Web Developer", Office = "Bangalore", Salary = 60000 });
            employees.Add(new Employee() { Id = 1, Name = "Irshad Ahmed", Position = "Anroid Developer", Office = "Bangalore", Salary = 50000 });
            return employees;
        }
    }
}
