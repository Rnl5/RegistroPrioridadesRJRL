﻿using System.ComponentModel.DataAnnotations;

namespace RegistroPrioridadesRJRL.Models
{
	public class Prioridades
	{
		[Key]
		public int IdPrioridad { get; set; }

		[Required(ErrorMessage = "El campo Descripcion es obligatorio")]
		public string? Descripcion { get; set; }


		[Range(1,31,ErrorMessage = "Debe de insertar un dia de compromiso dentro del rango [1-31]")]
		[Required (ErrorMessage ="El campo Dias Compromiso es obligatorio")] 
		public int DiasCompromiso { get; set; }
	}
}
