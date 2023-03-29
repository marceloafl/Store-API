using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController
    {
        [HttpGet]
        public string Get()
        {
            return "get aqui";
        }
    }
}
