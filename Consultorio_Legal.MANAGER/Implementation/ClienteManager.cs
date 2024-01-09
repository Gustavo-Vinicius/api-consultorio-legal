using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.CORE.SHARED.ModelViews;
using Consultorio_Legal.MANAGER.Interfaces;

namespace Consultorio_Legal.MANAGER.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteManager(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;

        }


        public async Task<Cliente?> GetClienteAsync(int id)
        {
            return await _clienteRepository.GetClienteAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return await _clienteRepository.GetClientesAsync();
        }

        public async Task<Cliente> InsertClienteAsync(NovoCliente novoCliente)
        {
            var cliente = _mapper.Map<Cliente>(novoCliente);
            return await _clienteRepository.InsertClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(AlteraCliente alteraCliente)
        {
            var cliente = _mapper.Map<Cliente>(alteraCliente);
            return await _clienteRepository.UpdateClienteAsync(cliente);
        }
        public async Task DeleteClienteAsync(int id)
        {
            await _clienteRepository.DeleteClienteAsync(id);
        }
    }
}