namespace TaskManagerAPI.DTOs
{
    public class UpdateTarefaDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataLimite { get; set; }
        public bool Concluida { get; set; }
    }

}
