using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Department;
using ServiceLayer.CommonServices;

namespace ServiceLayer.Services.DepartmentServices
{
    public class DepartmentServices : IDepartmentServices, IDepartmentRepository
    {
        private IDepartmentRepository _departmentRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public DepartmentServices(IDepartmentRepository departmentRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            this._departmentRepository = departmentRepository;
            this._modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(IDepartmentModel departmentModel)
        {
            _departmentRepository.Add(departmentModel);
        }

        public void Delete(IDepartmentModel departmentModel)
        {
            _departmentRepository.Delete(departmentModel);
        }

        public IEnumerable<DepartmentModel> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public DepartmentModel GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void Update(IDepartmentModel departmentModel)
        {
            _departmentRepository.Update(departmentModel);
        }

        public void ValidateModel(IDepartmentModel departmentModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(departmentModel);
            ValidateDepartmentUrl(departmentModel);
        }

        public void ValidateModelDataAnnotations(IDepartmentModel departmentModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(departmentModel);
        }

        private void ValidateDepartmentUrl(IDepartmentModel departmentModel)
        {
            StringBuilder errorsStringBuilder = new StringBuilder();
            if (string.IsNullOrEmpty(departmentModel.DepartmentUrl))
                errorsStringBuilder.Append("DepartmentUrl can't empyt");
            if (departmentModel.DepartmentUrl.Length < 5)
                errorsStringBuilder.Append("DepartmentUrl minimus lenght 5");
        }
    }
}