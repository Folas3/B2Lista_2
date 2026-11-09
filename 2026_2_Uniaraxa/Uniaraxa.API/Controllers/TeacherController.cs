
using Microsoft.AspNetCore.Mvc;
using Uniaraxa.Domain.Entities;
using Uniaraxa.Service.Interfaces;

namespace Uniaraxa.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        // INSERIR
        [HttpPost]
        public IActionResult Inserir(Teacher teacher)
        {
            var novoTeacher = _service.Inserir(teacher);

            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = novoTeacher.Id },
                novoTeacher
            );
        }

        // ATUALIZAR
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Teacher teacher)
        {
            teacher.Id = id;

            var atualizado = _service.Atualizar(teacher);

            if (!atualizado)
                return NotFound("Professor não encontrado.");

            return Ok(teacher);
        }

        // LISTAR TODOS
        [HttpGet]
        public IActionResult ListarTodos()
        {
            var teachers = _service.ListarTodos();

            return Ok(teachers);
        }

        // BUSCAR POR ID
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var teacher = _service.BuscarPorId(id);

            if (teacher == null)
                return NotFound("Professor não encontrado.");

            return Ok(teacher);
        }

        // REMOVER
        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            var removido = _service.Remover(id);

            if (!removido)
                return NotFound("Professor não encontrado.");

            return NoContent();
        }
    }
}
