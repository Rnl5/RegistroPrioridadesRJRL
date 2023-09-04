using System.ComponentModel.DataAnnotations;

namespace RegistroPrioridadesRJRL.Models
{
	public class Prioridad
	{
		[Key]
		public int IdPrioridad { get; set; }

		[Required(ErrorMessage = "Debe de insertar una descripcion valida")]
		public string? Descripcion { get; set; }


		[Range(1,31,ErrorMessage = "Debe de insertar un dia de compromiso dentro del rango [1-31]")] 
		public int DiasCompromiso { get; set; }
	}
}
