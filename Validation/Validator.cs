using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Registro_de_Tickets.Models;
namespace Registro_de_Tickets.Validation
{
    public class TicketValidator : AbstractValidator<Tickets>
    {
        int limite = 7;
        public TicketValidator() 
        {
            RuleFor(op => op.ClienteId)
                .NotEmpty()
                ;

        }

        
    }
}
