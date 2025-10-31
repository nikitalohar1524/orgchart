using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrgChartsJS.Models;

namespace OrgChartsJS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrgData()
        {
            // Normally you’d fetch from database using EF Core
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Aman Sharma", Title = "CEO", Img = "https://cdn-icons-png.flaticon.com/512/3135/3135715.png" },
                new Employee { Id = 2, Pid = 1, Name = "Neha Patel", Title = "VP Product", Img = "https://cdn-icons-png.flaticon.com/512/201/201634.png" },
                new Employee { Id = 3, Pid = 1, Name = "Karan Singh", Title = "VP Engineering", Img = "https://cdn-icons-png.flaticon.com/512/147/147144.png" },
                new Employee { Id = 4, Pid = 2, Name = "Ravi Kumar", Title = "Product Manager" },
                new Employee { Id = 5, Pid = 2, Name = "Sunita Rao", Title = "UX Lead" },
                new Employee { Id = 6, Pid = 3, Name = "Akash Verma", Title = "Engineering Manager" },
                new Employee { Id = 7, Pid = 3, Name = "QA Team", Title = "QA Lead" },
            };

            return Ok(employees);
        }
    }
}
