using System.Threading.Tasks;

namespace TesteEdinaldo.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
