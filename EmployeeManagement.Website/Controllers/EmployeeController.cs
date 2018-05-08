using EmployeeManagement.Website.Interface;
using EmployeeManagement.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeManagement.Website.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeManager employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        /// <summary>
        /// Get all employee details
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(List<Employee>))]

        public async Task<IHttpActionResult> GetAllEmployeeDetails()
        {

            var result = await employeeManager.GetAllEmployeeDetails();
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }


        /// <summary>
        /// Get all employee hierarchy
        /// </summary>
        /// <returns></returns>
        [Route("hierarchy")]
        [HttpGet]
        [ResponseType(typeof(List<Employee>))]

        public async Task<IHttpActionResult> GetAllEmployeeHierarchy()
        {

            var result = await employeeManager.GetAllEmployeeHierarchy();
            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

    }
}
