using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using TaskLists.Models;

namespace TaskLists.Controllers
{
    [Route("api/[controller]")]
    public class TaskListsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var tasks = new List<TaskList>()
            {
                
            };
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new TaskList { ListName = "Single Test", Description = "Desc" });
        }

        [HttpPut]
        public IActionResult Put([FromBody]TaskList list)
        {
            return Ok(list);
        }

        [HttpPost]
        public IActionResult Post([FromBody]TaskList list)
        {
            return Created("", list);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
