using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Tickets
{
    [Key]
    public int TicketId{get; set;}

    public DateTime Fecha {get; set;}

    [ForeignKey("ClienteId")]
    public int ClienteId {get; set;}

    [ForeignKey("SistemaId")]
    public int SistemaId {get; set;}

    [ForeignKey("PrioridadId")]
    public int PrioridadId {get; set;}

    [Required]
    public string? SolicitadoPor {get; set;}

    [Required]
    public string? Asunto {get; set;}

    [Required]
    public string? Descripcion {get; set;}






}