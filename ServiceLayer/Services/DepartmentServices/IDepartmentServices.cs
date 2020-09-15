using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;

namespace ServiceLayer.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        void ValidateModel(IDepartmentModel departmentModel);
        void ValidateModelDataAnnotations(IDepartmentModel departmentModel);
    }
}