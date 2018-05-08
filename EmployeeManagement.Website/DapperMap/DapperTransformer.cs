using Dapper.FluentMap;

namespace EmployeeManagement.Website.DapperMap
{
    public class DapperTransformer
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                 config.AddMap(new EmployeeMap());
            });
        }
    }
}