using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Service.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("exibirhelloworld")]
        public ActionResult<string> ExibirHelloWorld()
        {
            return "Hello World!";
        }
    }
}