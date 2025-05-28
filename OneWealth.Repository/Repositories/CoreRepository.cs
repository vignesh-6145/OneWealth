using System;
using System.Data.Common;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

using OneWealth.Repository.Data;
using OneWealth.Repository.Interfaces;

namespace OneWealth.Repository.Repositories;

public class CoreRepository: ICoreRepository
{
    internal ILogger<CoreRepository> _logger;
    internal OneWealthContext _context;
    public CoreRepository(ILogger<CoreRepository> logger, OneWealthContext context)
    {
        _logger = logger;
        _context = context;
    }

    public Task<IDbContextTransaction> GetTransactionAsync()
    {
        return _context.Database.BeginTransactionAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync().ConfigureAwait(false);
    }
}
