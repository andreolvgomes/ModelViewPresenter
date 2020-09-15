using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.DepartmentServices;

namespace ServicesLayer.Tests
{
    public class DepartmentServicesFixture
    {
        public DepartmentServicesFixture()
        {
            this._departmentModel = new DepartmentModel();
            this._departmentServices = new DepartmentServices(null, new ModelDataAnnotationCheck());
        }

        private IDepartmentModel _departmentModel;

        public DepartmentModel DepartmentModel
        {
            get { return (DepartmentModel)_departmentModel; }
            set { _departmentModel = value; }
        }

        private IDepartmentServices _departmentServices;

        public DepartmentServices DepartmentServices
        {
            get { return (DepartmentServices)_departmentServices; }
            set { _departmentServices = value; }
        }
    }
}