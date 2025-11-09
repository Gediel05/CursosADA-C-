using Microsoft.AspNetCore.Mvc;

namespace Aula1.Controllers
{
    public class TodoController : ControllerBase
    {

        [Route("api/todo")]
        public IActionResult GetTodos()
        {
            return Ok(new[] { "Comprar Ovo", "Comprar Leite", "Dar remédio pro Dog" });
        }

        [Route("api/todo/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(new[] { "Comprar Ovo", "Comprar Leite", "Dar remédio pro Dog" });
        }
    }
}