using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArchSE.Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfraMeController : ControllerBase
    {


        public InfraMeController()
        {
        }

        [HttpGet]
        public async Task<string> Get() =>
             "Oi";


    }
}