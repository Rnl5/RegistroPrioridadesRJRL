
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RegistroPrioridadesRJRL.Models;

public class SistemasBLL
{
    private readonly Context _context;

    public SistemasBLL(Context context){
        _context = context;
    }
    
    public bool YaExiste(int SistemaId){
        return _context.Sistemas.Any(c => c.SistemaId == SistemaId);
    }

    public bool Insertar(Sistemas sistemas)
    {
        _context.Sistemas.Add(sistemas);
        return _context.SaveChanges() > 0;
    }

    public bool Modificar(Sistemas sistemas){
        _context.Entry(sistemas).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Guardar(Sistemas sistemas)
    {
        if(!YaExiste(sistemas.SistemaId))
        {
            return this.Insertar(sistemas);
        }
        else
        {
            return this.Modificar(sistemas);
        }
    }

    public bool Eliminar(Sistemas sistemas)
    {
        _context.Entry(sistemas).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Sistemas? Buscar(int SistemaId)
    {
        return _context.Sistemas
            .Where(c => c.SistemaId== SistemaId)
            .AsNoTracking()
            .SingleOrDefault();
    }

    public List<Sistemas> GetSistemas(Expression<Func<Sistemas, bool>> Criterio)
    {
        return _context.Sistemas
            .AsNoTracking()
            .Where(Criterio)
            .ToList();
    }

    public bool ExisteDatos(Sistemas sistemas)
    {
        var mismosDatos = _context.Sistemas.Any(c =>c.Nombre == sistemas.Nombre);
        if(mismosDatos)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}