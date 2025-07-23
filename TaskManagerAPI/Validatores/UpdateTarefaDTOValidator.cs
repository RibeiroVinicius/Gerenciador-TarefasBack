using FluentValidation;
using TaskManagerAPI.DTOs;

namespace TaskManagerAPI.Validatores
{
    public class UpdateTarefaDTOValidator : AbstractValidator<UpdateTarefaDTO>
    {
        public UpdateTarefaDTOValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty()
                .WithMessage("O título é obrigatório.");

            RuleFor(x => x.DataLimite)
                .GreaterThan(DateTime.Now)
                .WithMessage("A data limite deve ser uma data futura.");
        }
    }

}
