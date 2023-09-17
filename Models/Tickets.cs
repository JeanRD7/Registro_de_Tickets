using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace Registro_de_Tickets.Models
{
    public class Tickets
    {
        [Key]

        public int TicketId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }
        [Required (ErrorMessage ="No puede dejar el campo vacio"), MaxLength(3)]
        public int SistemaId { get; set;}
        [Required(ErrorMessage = "No puede dejar el campo vacio"), MaxLength(3)]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio")]
        public string? Descripcion { get; set; }

    }
}
