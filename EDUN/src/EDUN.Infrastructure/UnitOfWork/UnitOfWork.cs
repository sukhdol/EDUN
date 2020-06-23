using System.Threading.Tasks;
using EDUN.Application.Common.Interfaces;
using EDUN.Domain.Interfaces.UnitOfWork;

namespace EDUN.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public UnitOfWork(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        
        public async Task Complete()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}