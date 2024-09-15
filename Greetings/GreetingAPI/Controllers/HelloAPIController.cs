using Microsoft.AspNetCore.Mvc;

namespace GreetingAPI.Controllers
{
 
        [Route("api/HelloAPI")]
        [ApiController]
        public class HelloAPIController : ControllerBase
        {
            [HttpGet]
            public ActionResult<String> Hello()
            {
                return Ok("Hello");
            }
            [HttpGet("name")]
            public ActionResult<String> HelloName(string name)
            {
                name = name.Trim();
                if (name == null)
                {
                    return BadRequest();
                }
                else
                {

                    foreach (char c in name)
                    {
                        if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                        {
                            return BadRequest("Name cannot be digits or special characters");
                        }
                    }
                    return Ok("Hello " + name);


                }
            }
        }
    }
