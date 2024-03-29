using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;
using FluentValidation;

namespace Consultorio_Legal.MANAGER.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(x => x.Nome).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.Documento).NotNull().NotEmpty().MinimumLength(4).MaximumLength(14);
            RuleFor(x => x.Telefones).NotNull().NotEmpty();
            RuleFor(x => x.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("Sexo precisa ser M ou F");



        }

        private bool IsMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
        
    }
}