using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentRepository
    {
        void Add(IDepartmentModel departmentModel);
        void Update(IDepartmentModel departmentModel);
        void Delete(IDepartmentModel departmentModel);
        IEnumerable<DepartmentModel> GetAll();
        DepartmentModel GetById(int id);
    }
}