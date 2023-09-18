using System.ComponentModel.DataAnnotations;

public class Sistemas{

    [Key]
    public int SistemaId{get; set;}


    [Required(ErrorMessage = "El campo Nombre es necesario")]
    public string? Nombre{get; set;}

}