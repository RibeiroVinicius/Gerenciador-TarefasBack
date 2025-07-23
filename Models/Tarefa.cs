namespace TaskManagerAPI.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataLimite { get; set; }
        public bool Concluida { get; set; }
    }

}
