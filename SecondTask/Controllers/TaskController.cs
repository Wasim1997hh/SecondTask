using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecondTask.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecondTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly SecondTaskContext _secondTaskContext;
        public TaskController(SecondTaskContext secondTaskContext)
        {
            _secondTaskContext = secondTaskContext;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public IActionResult Get()
        {
            var cc = _secondTaskContext.Items.Select(x => new { x.Id, x.Name,x.SubCategoryId,x.SubCategory  }).ToList();
            return Ok(cc);
        }
        //[HttpGet]
        //public IActionResult Export()
        //{
           
        //    var cc = _secondTaskContext.Items.Select(x => new { x.Id, x.Name, x.SubCategory }).ToList();
        //    var builder = new StringBuilder();
        //    builder.AppendLine("Id,Name");
        //    foreach (var item in cc)
        //    {
        //        builder.AppendLine($"{item.Id} , {item.Name}");
        //    }
        //    var export = File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "cc.csv");
        //    return Ok(export);
        //}

        // GET api/<TaskController>/5
       

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
