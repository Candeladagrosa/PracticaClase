using Microsoft.AspNetCore.Mvc;
using PracticaClase.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticaClase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        // POST api/<AutoController>
        [HttpPost]
        public List<Auto> GetAutos(Auto auto)
        {
            List<Auto> autos = new List<Auto>();

            for(int i = 0; i < 10; i++)
            {
                autos.Add(auto);
            }

            return autos;
        }
    }
}
