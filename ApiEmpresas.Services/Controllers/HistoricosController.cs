using ApiEmpresas.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(HistoricosPostModel model)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(HistoricosPutModel model)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<HistoricosGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(HistoricosGetModel), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }
    }
}
