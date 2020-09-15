using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Department
{
    public interface IDepartmentModel
    {
        int DepartmentID { get; set; }
        string DepartmentName { get; set; }
        string DepartmentUrl { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string CityLocation { get; set; }
        string StateLocation { get; set; }
    }
}
