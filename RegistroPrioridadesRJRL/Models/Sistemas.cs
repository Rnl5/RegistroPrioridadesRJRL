using System.ComponentModel.DataAnnotations;

public class Sistemas{

    [Key]
    public int SistemaId{get; set;}


    [Required (ErrorMessage = "El campo nombre es requerido")]
    [RegularExpression(@"^[a-z A-Z \s]$",
    ErrorMessage ="Debe de insertar un nombre valido")]
    public string? Nombre{get; set;}

}