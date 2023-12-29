using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio_Legal.CORE.Domain;

namespace Consultorio_Legal.MANAGER.Interfaces
{
    public interface IClienteManager
    {
        Task<IEnumerable<Cliente>> GetClientesAsync ();
        Task<Cliente?> GetClienteAsync(int id);
    }
}