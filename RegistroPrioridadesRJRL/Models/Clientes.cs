using System.ComponentModel.DataAnnotations;

namespace ClientesRJRL.Models;

public class Clientes{

    [Key]
    public int ClienteId {get; set;}

    [Required(ErrorMessage = "Debe de insertar un nombre")]
    [RegularExpression(@"^[a-zA-Z\s]+$",
    ErrorMessage ="Debe de insertar un nombre valido")]
    public string? Nombre{get; set;}

    [Required(ErrorMessage ="Debe de insertar un numero telefonico")]
    [RegularExpression(@"^[0-9- \s]{10,12}$",
    ErrorMessage ="Debe de insertar un numero telefonico con el formato correcto")]
    [Phone]
    public string? Telefono{get; set;}

    [Required(ErrorMessage ="Debe de insertar un numero de celular")]
    [RegularExpression(@"^[0-9- \s]{10,12}$",
    ErrorMessage ="Debe de insertar un numero celular con el formato correcto")]
    [Phone]
    public string? Celular{get; set;}

    [Required(ErrorMessage ="Debe de insertar un RNC")]
    [StringLength(11, ErrorMessage ="El RNC debe de tener 11 caracteres")]
    public string? Rnc{get; set;}

    [Required(ErrorMessage ="El campo Correo Electronico es obligatorio")]
    [EmailAddress]
    public string? Email{get; set;}

    [Required(ErrorMessage ="Debe de insertar una direccion")]
    public string? Direccion{get; set;}
}