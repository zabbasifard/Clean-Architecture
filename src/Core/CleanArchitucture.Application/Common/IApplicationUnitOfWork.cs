using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitucture.Application.Common
{
    public interface IApplicationUnitOfWork : IunitOfWork
    {
        public DbSet<User> Users { get;  }
    }

    public interface IunitOfWork : IDisposable, IAsyncDisposable
    {
        public Task<Result> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
