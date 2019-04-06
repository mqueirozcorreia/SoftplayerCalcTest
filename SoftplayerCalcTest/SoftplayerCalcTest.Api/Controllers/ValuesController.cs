using Microsoft.AspNetCore.Mvc;
using SoftplayerCalcTest.Domain;

namespace SoftplayerCalcTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet("/calculajuros")]
        public ActionResult Get(decimal valorInicial, int meses)
        {
            if (meses < 1 && valorInicial <= 0) return BadRequest((Calculador) null);
            var calculador = new Calculador(valorInicial, meses);
            return Ok(calculador.ValorFinal());

        }

        // GET api/values/5
        [HttpGet("/showmethecode")]
        public ActionResult<string> Get()
        {
            return "https://github.com/rodrigodosanjosoliveira/SoftplayerCalcTest.git";
        }
    }
}
