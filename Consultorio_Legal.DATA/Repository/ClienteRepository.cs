using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.DATA.Context;
using Consultorio_Legal.MANAGER.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Consultorio_Legal.DATA.Repository
{
    #nullable disable
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConsultorioLegalContext _context;
        public ClienteRepository(ConsultorioLegalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync ()
        {
            return await _context.Clientes
            .Include(p => p.Endereco)
            .Include(p => p.Telefones)
            .AsNoTracking()
            .ToListAsync();
        }

        public async Task<Cliente> GetClienteAsync(int id)
        {
            return await _context.Clientes
            .Include(p => p.Endereco)
            .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await _context.Clientes.FindAsync(cliente.Id);

            if(clienteConsultado == null)
            {
                return null;
            }

            // clienteConsultado.Nome = cliente.Nome;
            // clienteConsultado.DataNascimento = cliente.DataNascimento;

            _context.Entry(clienteConsultado).CurrentValues.SetValues(cliente);

            _context.Clientes.Update(clienteConsultado);
            await _context.SaveChangesAsync();
            return clienteConsultado;

        }

        public async Task DeleteClienteAsync(int id)
        {
            var clienteConsultado = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clienteConsultado);
            await _context.SaveChangesAsync();
        }
    }
}