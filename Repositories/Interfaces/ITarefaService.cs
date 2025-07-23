using TaskManagerAPI.Models;

namespace TaskManagerAPI.Services.Interfaces
{
    public interface ITarefaService
    {
        Task<IEnumerable<Tarefa>> GetAllAsync(bool? concluida, DateTime? de, DateTime? ate);
        Task<Tarefa?> GetByIdAsync(Guid id);
        Task CreateAsync(Tarefa tarefa);
        Task UpdateAsync(Tarefa tarefa);
        Task DeleteAsync(Guid id);
    }
}
