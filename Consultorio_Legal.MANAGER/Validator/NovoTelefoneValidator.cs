using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.SHARED.ModelViews;
using FluentValidation;

namespace Consultorio_Legal.MANAGER.Validator
{
    public class NovoTelefoneValidator: AbstractValidator<NovoTelefone>
{
    public NovoTelefoneValidator()
    {
        RuleFor(p => p.Numero).Matches("[1-9][0-9]{10}").WithMessage("O telefone tem que ter o formato [2-9][0-9]{10}");
    }
}
}