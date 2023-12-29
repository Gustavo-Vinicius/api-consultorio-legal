using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.MANAGER.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio_Legal.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteManager _clienteManager;

        public ClientesController(IClienteManager clienteManager)
        {
            _clienteManager = clienteManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){

            return Ok(await _clienteManager.GetClientesAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clienteManager.GetClienteAsync(id));
        }

        [HttpPost]
        public void Post([FromBody] string value){

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value){

        }

        [HttpDelete("{id}")]
        public void Delete(int id){

        }
    }
}