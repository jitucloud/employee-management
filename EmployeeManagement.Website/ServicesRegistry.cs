using Autofac;
using EmployeeManagement.Website.Helper;
using EmployeeManagement.Website.Interface;
using EmployeeManagement.Website.Manager;

namespace EmployeeManagement.Website
{
    public class ServicesRegistry
    {
        public void Register(ContainerBuilder builder)
        {
            var notesDB = new DbManager(ConfigManager.GetItemAsString("EmployeeDB", "flightbooking")); // This is the DB available to me
            var noteManager = new EmployeeManager(notesDB);
            builder.RegisterInstance<IEmployeeManager>(noteManager);
        }
    }
}