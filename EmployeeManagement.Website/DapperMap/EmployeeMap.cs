using Dapper.FluentMap.Mapping;
using EmployeeManagement.Website.Models;

namespace EmployeeManagement.Website.DapperMap
{
    public class EmployeeMap : EntityMap<Employee>
    {
        public EmployeeMap()
        {
            Map(c => c.Name).ToColumn("name");
            Map(c => c.Id).ToColumn("id");
            Map(c => c.Age).ToColumn("age");
            Map(c => c.ManagerID).ToColumn("manager_id");

        }
    }
}