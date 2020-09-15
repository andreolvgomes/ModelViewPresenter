using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using InfrastructureLayer.DataAccess.Repositories.Specific.Department;
using ServiceLayer.CommonServices;
using ServiceLayer.Services.DepartmentServices;
using Xunit;

namespace ServicesLayer.Tests
{
    public class DepartmentServicesValidationTests
    {
        public DepartmentServicesValidationTests()
        {
            this._departmentModel = new DepartmentModel();
            this._departmentServices = new DepartmentServices(new DepartmentRepository(""), new ModelDataAnnotationCheck());
        }

        [Fact]
        public void ShouldReturnListOfDepartment()
        {
            List<DepartmentModel> departmentModelList = (List<DepartmentModel>)DepartmentServices.GetAll();
        }

        private DepartmentModel _departmentModel;

        public DepartmentModel DepartmentModel
        {
            get { return (DepartmentModel)_departmentModel; }
            set { _departmentModel = value; }
        }

        private DepartmentServices _departmentServices;

        public DepartmentServices DepartmentServices
        {
            get { return (DepartmentServices)_departmentServices; }
            set { _departmentServices = value; }
        }
    }
}
