using CleanArchitucture.Application.Common;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CleanArchitucture.Infrastructure.Persistence.UnitOfWork
{
    public partial class ApplicationUnitOfWork(ApplicationDbContext applicationDbContext) : IApplicationUnitOfWork
    {
        private readonly ApplicationDbContext _context = applicationDbContext;

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
            GC.SuppressFinalize(this);
        }

        public async Task<Result> SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                return Result.Success();
            }
            catch (DBConcurrencyException ex)
            {
                return Result.Failure(ex.Message);
            }
            catch (DbUpdateException ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
