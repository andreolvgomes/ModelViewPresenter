using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using ServiceLayer.Services.DepartmentServices;

namespace InfrastructureLayer.DataAccess.Repositories.Specific.Department
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private string _connectionString = string.Empty;

        public DepartmentRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public void Add(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public DepartmentModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(IDepartmentModel departmentModel)
        {
            throw new NotImplementedException();
        }
    }
}
