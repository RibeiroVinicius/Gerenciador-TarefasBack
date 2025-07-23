using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;
using TaskManagerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    [Authorize]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaService _tarefaService;
        private readonly IMapper _mapper;

        public TarefasController(ITarefaService tarefaService, IMapper mapper)
        {
            _tarefaService = tarefaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarefaDTO>>> GetAllTasks([FromQuery] bool? concluida, [FromQuery] DateTime? de, [FromQuery] DateTime? ate)
        {
            var tarefas = await _tarefaService.GetAllAsync(concluida, de, ate);
            var tarefasDTO = _mapper.Map<IEnumerable<TarefaDTO>>(tarefas);
            return Ok(tarefasDTO);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaDTO>> GetById(Guid id)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            if (tarefa == null)
                return NotFound();

            return Ok(_mapper.Map<TarefaDTO>(tarefa));
        }

        [HttpPost]
        public async Task<ActionResult<TarefaDTO>> CreateTask(CreateTarefaDTO dto)
        {
            var tarefa = _mapper.Map<Tarefa>(dto);
            await _tarefaService.CreateAsync(tarefa);
            var result = _mapper.Map<TarefaDTO>(tarefa);

            return CreatedAtAction(nameof(GetById), new { id = tarefa.Id }, result);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateTask(Guid id, UpdateTarefaDTO dto)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            if (tarefa == null)
                return NotFound();

            _mapper.Map(dto, tarefa); // atualiza os campos
            await _tarefaService.UpdateAsync(tarefa);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            var tarefa = await _tarefaService.GetByIdAsync(id);
            if (tarefa == null)
                return NotFound();

            await _tarefaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
