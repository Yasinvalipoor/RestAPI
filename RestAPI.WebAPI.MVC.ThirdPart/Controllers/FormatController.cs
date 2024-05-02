using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.WebAPI.MVC.ThirdPart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Here we test the type of return format that should be used with "Postman" and see if the output is application/jason or text/plain.
    public class FormatController : ControllerBase
    {
        //text/plain
        [HttpGet("str")]
        public string GetString() => "Hi";

        //application/jason
        [HttpGet("int")]
        public int GetInt() => 1;

        //application/jason
        [HttpGet("obj")]
        public Object GetObj() => new { Product = "Book" , Price = "10000" };
    }
}
