using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        // GET
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var car = new Car()
            {
                Id = id,
                Name = "Ferrari",
                Description = "Super fast car"
            };

            return Ok(car);
        }

        // POST
        [HttpPost]
        public IActionResult Add([FromBody] Car model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Add", new { id = 5 });
        }

        // PUT
        [HttpPut]
        public IActionResult Put([FromBody] Car model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return CreatedAtAction("Put", new { id = model.Id });
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();     //204 - successfull, but no content
            //return Ok(new {id = 5});
        }
    }
}