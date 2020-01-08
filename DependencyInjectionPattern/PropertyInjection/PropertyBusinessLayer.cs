using System;
using System.Collections.Generic;

namespace DependencyInjectionPattern.PropertyInjection
{
    class PropertyBusinessLayer
    {
        private IDataAccessLayer dataAccessLayer;

        public IDataAccessLayer dataAccessObject
        {
            set
            {
                this.dataAccessLayer = value;
            }
            get
            {
                if (dataAccessObject == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return dataAccessLayer;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return dataAccessLayer.GetEmployees();
        }
    }
}
