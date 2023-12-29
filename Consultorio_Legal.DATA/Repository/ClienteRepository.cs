using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.DATA.Context;
using Consultorio_Legal.MANAGER.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_Legal.DATA.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConsultorioLegalContext _context;
        public ClienteRepository(ConsultorioLegalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync ()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente?> GetClienteAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }


    }
}