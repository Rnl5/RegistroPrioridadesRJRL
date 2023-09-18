using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Radzen.Blazor.Rendering;
using RegistroPrioridadesRJRL.Models;

public class TicketsBLL
{
    private readonly Context _context;

    public TicketsBLL(Context context)
    {
        _context = context;
    }
    
    public bool YaExiste(int TicketId)
    {
        return _context.Tickets.Any(c => c.TicketId == TicketId);
    }

    public bool Insertar(Tickets tickets)
    {
        _context.Tickets.Add(tickets);
        return _context.SaveChanges() > 0;
    }

    public bool Modificar(Tickets tickets)
    {
        _context.Entry(tickets).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Guardar(Tickets tickets)
    {
        if(!YaExiste(tickets.TicketId))
        {
            return this.Insertar(tickets);
        }
        else
        {
            return this.Modificar(tickets);
        }
    }

    public bool Eliminar(Tickets tickets)
    {
        _context.Entry(tickets).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Tickets? Buscar(int TicketId)
    {
        return _context.Tickets
            .Where(c => c.TicketId == TicketId)
            .AsNoTracking()
            .SingleOrDefault();
    }

    public List<Tickets> GetTickets(Expression<Func<Tickets, bool>> Criterio)
    {
        return _context.Tickets
            .AsNoTracking()
            .Where(Criterio)
            .ToList();
    }

    public bool ExisteDatos(Tickets tickets)
    {
        var mismosDatos = _context.Tickets.Any(c =>c.Fecha == tickets.Fecha || c.SolicitadoPor == tickets.SolicitadoPor || c.Asunto == tickets.Asunto || c.Descripcion == tickets.Descripcion);
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