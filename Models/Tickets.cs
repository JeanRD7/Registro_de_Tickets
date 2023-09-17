using System.ComponentModel.DataAnnotations;

namespace Registro_de_Tickets.Models
{
    public class Tickets
    {
        [Key]

        public int TicketId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "No puede dejar el campo vacio")]
        public int? ClienteId { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio")]
        public int? SistemaId { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio"),MaxLength(15)]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio"),MaxLength(20)]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "No puede dejar el campo vacio"),MaxLength(30)]
        public string? Descripcion { get; set; }

    }
}
