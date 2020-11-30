using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.IEmployeeManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpManager _empManager;

        public EmployeeController(IEmpManager empManager) 
        {
            _empManager = empManager;
        }
        public ActionResult Get() 
        {
            return Ok(_empManager.getEmployeeView());

        }
    }
}