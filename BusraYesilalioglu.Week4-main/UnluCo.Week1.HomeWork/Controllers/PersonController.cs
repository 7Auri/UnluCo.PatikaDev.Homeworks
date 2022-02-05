using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UnluCo.Week1.HomeWork.Models;


namespace UnluCo.Week1.HomeWork.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PersonController : ControllerBase
    {

        [HttpGet("persons")]
        public IActionResult Get()
        {
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("persons/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //[Authorize(Roles ="Admin")]
        [HttpPost("person")]
        public IActionResult Post([FromBody] Person person)
        {
            return Ok();

        }


    }
}
