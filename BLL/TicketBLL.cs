using Microsoft.EntityFrameworkCore;
using Registro_de_Tickets.DAL;
using Registro_de_Tickets.Models;
using System.Linq.Expressions;

namespace Registro_de_Tickets.BLL
{
    public class TicketBLL
    {
        private readonly Context _context;

        public TicketBLL(Context context)
        {
            _context = context;
        }

        public bool Existe(int TicketId)
        {
            return _context.Tickets.Any(op => op.TicketId == TicketId);
        }

        private bool Insertar(Tickets Ticket)
        {
            _context.Tickets.Add(Ticket);
            return _context.SaveChanges() > 0;
        }

        private bool Modificar(Tickets Ticket)
        {
            var existe = _context.Tickets.Find(Ticket.TicketId);
            if (existe != null)
            {
                _context.Entry(existe).CurrentValues.SetValues(Ticket);
                return _context.SaveChanges() > 0;
            }

            return false;
        }

        public bool Guardar(Tickets Ticket)
        {
            if (!Existe(Ticket.TicketId))
                return this.Insertar(Ticket);
            else
                return this.Modificar(Ticket);
        }

        public bool Eliminar(Tickets TicketId)
        {
            _context.Tickets.Remove(TicketId);
            int cantidad = _context.SaveChanges();
            return cantidad > 0;
        }

        public Tickets? Buscar(int TicketId)
        {
            return _context.Tickets.Where(op => op.TicketId == TicketId)
                .AsNoTracking()
                .SingleOrDefault();
        }

        public List<Tickets> GetList(Expression<Func<Tickets, bool>> criterio)
        {
            return _context.Tickets
                .AsNoTracking()
                .Where(criterio)
                .ToList();
        }

        public bool VerificarExistencia(Tickets Ticket)
        {
            var clienteIgual = _context.Tickets.Any(op => op.ClienteId == Ticket.ClienteId);

            if (clienteIgual)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
