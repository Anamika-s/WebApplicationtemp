using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationtemp.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IActionResult Get()
        {
            List<string> list = new List<string>()
            { "aaa", "bbb"};
            return Ok(list);
        }
    }
}
