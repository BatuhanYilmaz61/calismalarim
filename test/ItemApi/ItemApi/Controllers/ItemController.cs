using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public string gretings()
        {
            return "naber";
        }
    }
}
