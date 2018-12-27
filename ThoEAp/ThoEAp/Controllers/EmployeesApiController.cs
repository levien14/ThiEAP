using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThoEAp.Models;

namespace ThoEAp.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class EmployeesApiController : ControllerBase
    {
        private readonly ThoEApContext _context;

        public EmployeesApiController(ThoEApContext context)
        {
            _context = context;
        }

        // GET: api/EmployeesApi
        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            return _context.Employee;
        }
        
    }
}