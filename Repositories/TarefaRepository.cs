using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Models;
using TaskManagerAPI.Repositories.Interfaces;

namespace TaskManagerAPI.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AppDbContext _context;

        public TarefaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarefa>> GetAllAsync(bool? concluida, DateTime? de, DateTime? ate)
        {
            var query = _context.Tarefas.AsQueryable();

            if (concluida.HasValue)
                query = query.Where(t => t.Concluida == concluida.Value);

            if (de.HasValue)
                query = query.Where(t => t.DataLimite >= de.Value);

            if (ate.HasValue)
                query = query.Where(t => t.DataLimite <= ate.Value);

            return await query.OrderBy(t => t.DataLimite).ToListAsync();
        }

        public async Task<Tarefa?> GetByIdAsync(Guid id)
        {
            return await _context.Tarefas.FindAsync(id);
        }

        public async Task CreateAsync(Tarefa tarefa)
        {
            tarefa.Id = Guid.NewGuid();
            _context.Tarefas.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var tarefa = await _context.Tarefas.FindAsync(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                await _context.SaveChangesAsync();
            }
        }
    }
}
