using Consultorio_Legal.CORE.Domain;

namespace Consultorio_Legal.MANAGER.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientesAsync ();
        Task<Cliente?> GetClienteAsync(int id);
    }
}