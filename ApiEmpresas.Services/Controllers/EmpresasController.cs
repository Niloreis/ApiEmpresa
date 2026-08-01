using ApiEmpresas.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEmpresas.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        [HttpPost]
            public IActionResult Post(EmpresasPostModel model)
            {
                return Ok();
            }

            [HttpPut]
            public IActionResult Put(EmpresasPutModel model)
            {
                return Ok();
            }

        [HttpDelete("{id}")]
            public IActionResult Delete( Guid? id )
            { 
                return Ok();
            }

         [HttpGet]
            [ProducesResponseType(typeof(List<EmpresasGetModel>), 200)]
            public IActionResult GetAll() 
            {
                return Ok();        
            }

         [HttpGet("{id}")]
            [ProducesResponseType(typeof(EmpresasGetModel),200)]
            public IActionResult GetById(Guid? id)
            {
                return Ok();
            }

    }
}
