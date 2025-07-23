using FluentValidation;
using TaskManagerAPI.DTOs;

namespace TaskManagerAPI.Validatores
{
    public class TarefaValidator : AbstractValidator<TarefaDTO>
    {
        public TarefaValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("Título é obrigatório");
            RuleFor(x => x.DataLimite).GreaterThan(DateTime.Now).WithMessage("Data deve ser futura");
        }
    }

}
