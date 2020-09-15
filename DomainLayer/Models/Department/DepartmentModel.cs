using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Department
{
    public class DepartmentModel: IDepartmentModel
    {
        public int DepartmentID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Department name is requred")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Department name is much be between 5 and 20 characters")]
        public string DepartmentName { get; set; }
        public string DepartmentUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CityLocation { get; set; }
        public string StateLocation { get; set; }
    }
}