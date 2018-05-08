using Dapper;
using EmployeeManagement.Website.Interface;
using EmployeeManagement.Website.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Website.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        private IDbManager dbManager;
        public EmployeeManager(IDbManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public async Task<List<Employee>> GetAllEmployeeDetails()
        {
            var sql = $@"SELECT * FROM [flightbooking].[dbo].[employees] WITH (NOLOCK)";

            using (var db = dbManager.GetOpenConnection())
            {
                var employeeListList = await db.QueryAsync<Employee>(sql);
                if (employeeListList != null && employeeListList.Count() > 0)
                    return employeeListList.ToList();
            }
            return null;
        }
        public async Task<List<Employee>> GetAllEmployeeHierarchy()
        {
            return await GetAllEmployeeDetails();
        }

    }
}