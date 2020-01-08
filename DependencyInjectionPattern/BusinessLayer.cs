using System.Collections.Generic;

namespace DependencyInjectionPattern
{
    class BusinessLayer
    {
        public IDataAccessLayer DataAccessLayer;

        public BusinessLayer(IDataAccessLayer dataAccessLayer)
        {
           DataAccessLayer = dataAccessLayer;
        }

        public List<Employee> GetAllEmployees()
        {
            return DataAccessLayer.GetEmployees();
        }
    }
}
