using System.Threading.Tasks;

namespace EDUN.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task Complete();
    }
}