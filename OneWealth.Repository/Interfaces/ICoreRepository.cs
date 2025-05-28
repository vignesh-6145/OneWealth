using System;

using Microsoft.EntityFrameworkCore.Storage;

namespace OneWealth.Repository.Interfaces;

public interface ICoreRepository
{
    public Task<IDbContextTransaction> GetTransactionAsync();
    public Task SaveChangesAsync();
}
