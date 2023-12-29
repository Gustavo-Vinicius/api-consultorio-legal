using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.MANAGER.Interfaces;

namespace Consultorio_Legal.MANAGER.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteManager(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente?> GetClienteAsync(int id)
        {
            return await _clienteRepository.GetClienteAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }
    }
}