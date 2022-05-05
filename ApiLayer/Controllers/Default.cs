using ApiLayer.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Default : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var EList = c.Employees.ToList();
            return Ok(EList);

        }
        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            using var c = new Context();
            c.Add(e);
            c.SaveChanges();
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult EmplooyeGetById(int id)
        {
            using var c = new Context();
            var emp = c.Employees.FirstOrDefault(i => i.Id == id);
            return Ok(emp);

        }
        [HttpDelete("{id}")]
        public IActionResult EmplooyeDelete(int id)
        {
            using var c = new Context();
            var emp = c.Employees.FirstOrDefault(i => i.Id == id);
            c.Remove(emp);
            c.SaveChanges();
            return Ok();

        }
        [HttpPut("{id}")]
        public IActionResult EmplooyeUpdate(Employee e,int id)
        {
            using var c = new Context();
            var emp = c.Employees.FirstOrDefault(i => i.Id == id);
            emp.Name = e.Name;
            c.SaveChanges();
            return Ok();

        }

    }
}
