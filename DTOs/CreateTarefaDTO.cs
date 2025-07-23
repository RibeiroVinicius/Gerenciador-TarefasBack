namespace TaskManagerAPI.DTOs
{
    public class CreateTarefaDTO
    {
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public DateTime DataLimite { get; set; }
    }

}
