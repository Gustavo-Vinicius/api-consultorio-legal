using Consultorio_Legal.CORE.Domain;
using Consultorio_Legal.CORE.SHARED.ModelViews;

namespace Consultorio_Legal.MANAGER.Interfaces
{
    public interface IClienteManager
    {
        Task<IEnumerable<Cliente>> GetClientesAsync ();
        Task<Cliente?> GetClienteAsync(int id);
        Task<Cliente> InsertClienteAsync(NovoCliente novoCliente);
        Task<Cliente> UpdateClienteAsync(AlteraCliente alteraCliente);
        Task DeleteClienteAsync(int id);
    }
}