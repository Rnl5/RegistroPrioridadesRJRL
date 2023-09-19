using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
public class Tickets
{
    [Key]
    public int TicketId{get; set;}

    [Required(ErrorMessage ="El campo Fecha es obligatorio")]
    public DateTime Fecha {get; set;} = DateTime.Now;

    [ForeignKey("ClienteId")]
    public int ClienteId {get; set;}

    [ForeignKey("SistemaId")]
    public int SistemaId {get; set;}

    [ForeignKey("PrioridadId")]
    public int PrioridadId {get; set;}

    [Required (ErrorMessage = "El campo Solicitado Por se encuentra vacio")]
    public string? SolicitadoPor {get; set;}

    [Required(ErrorMessage ="El Campo Asunto se encuentra vacio")]
    public string? Asunto {get; set;}

    [Required(ErrorMessage ="El campo Descripcion se encuentra vacio")]
    public string? Descripcion {get; set;}
}