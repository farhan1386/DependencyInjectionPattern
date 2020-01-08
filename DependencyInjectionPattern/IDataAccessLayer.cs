using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    interface IDataAccessLayer
    {
        List<Employee> GetEmployees();
    }
}
