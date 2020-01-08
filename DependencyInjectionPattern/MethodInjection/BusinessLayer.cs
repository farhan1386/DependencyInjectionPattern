using System.Collections.Generic;

namespace DependencyInjectionPattern.MethodInjection
{
    class BusinessLayer
    {
        public IDataAccessLayer DataAccessLayer;

        public List<Employee> GetAllEmployees(IDataAccessLayer dataAccessLayer)
        {
            DataAccessLayer = dataAccessLayer;
            return dataAccessLayer.GetEmployees();
        }
    }
}
