using TaskManagerAPI.Models;
using TaskManagerAPI.Repositories.Interfaces;
using TaskManagerAPI.Services.Interfaces;

namespace TaskManagerAPI.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repository;

        public TarefaService(ITarefaRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Tarefa>> GetAllAsync(bool? concluida, DateTime? de, DateTime? ate)
            => _repository.GetAllAsync(concluida, de, ate);

        public Task<Tarefa?> GetByIdAsync(Guid id)
            => _repository.GetByIdAsync(id);

        public Task CreateAsync(Tarefa tarefa)
            => _repository.CreateAsync(tarefa);

        public Task UpdateAsync(Tarefa tarefa)
            => _repository.UpdateAsync(tarefa);

        public Task DeleteAsync(Guid id)
            => _repository.DeleteAsync(id);
    }
}
