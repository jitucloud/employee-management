using EmployeeManagement.Website.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Website.Interface
{
    public interface IEmployeeManager
    {
        Task<List<Employee>> GetAllEmployeeDetails();
        Task<List<Employee>> GetAllEmployeeHierarchy();

    }
}