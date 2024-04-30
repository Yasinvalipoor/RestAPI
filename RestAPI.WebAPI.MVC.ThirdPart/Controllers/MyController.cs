using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.WebAPI.MVC.ThirdPart.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]

    public class MyController : ControllerBase
    {
        public string GetName()
        {
            return "Hello Every Body";
        }
    }
}
 