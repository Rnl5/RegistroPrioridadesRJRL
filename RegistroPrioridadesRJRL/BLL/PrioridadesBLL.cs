using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using RegistroPrioridadesRJRL.Models;
using System.Linq.Expressions;

namespace RegistroPrioridadesRJRL.BLL
{
	public class PrioridadesBLL
	{
		private readonly Context _context;

		public PrioridadesBLL(Context context)
		{
			_context = context;
		}

		public bool Existe(int IdPrioridad)
		{
			return _context.prioridades.Any(p => p.IdPrioridad == IdPrioridad);
		}

		public bool DescripcionRepetida(string descripcion)
		{
			return _context.prioridades.Any(p => p.Descripcion == descripcion);
		}

		private bool Insertar(Prioridades prioridad)
		{
			_context.prioridades.Add(prioridad);
			return _context.SaveChanges() > 0;
		}

		public bool Modificar(Prioridades prioridad)
		{
			_context.Entry(prioridad).State = EntityState.Modified;
			return _context.SaveChanges() > 0;

		}

		public bool Guardar(Prioridades prioridad)
		{
			if (!Existe(prioridad.IdPrioridad) && !DescripcionRepetida(prioridad.Descripcion)) 
			{
				return this.Insertar(prioridad);
			}
			else
			{
				return this.Modificar(prioridad);
			}
			
		}

		public bool Eliminar(Prioridades prioridad)
		{
			_context.Entry(prioridad).State = EntityState.Deleted;
			return _context.SaveChanges() > 0;
		}

		public Prioridades? Buscar(int IdPrioridad)
		{
			return _context.prioridades
				.Where(p => p.IdPrioridad == IdPrioridad)
				.AsNoTracking()
				.SingleOrDefault();

		}

		public List<Prioridades> GetList(Expression<Func<Prioridades, bool>> Criterio)
		{
			return _context.prioridades
				.AsNoTracking()
				.Where(Criterio)
				.ToList();
		}

        public bool Validar()
        {
			return _context.prioridades != null;
        }



    }
}
