﻿using System.Threading;
using System.Threading.Tasks;

namespace NLayer.DAL.Repositories.Base
{
    public interface IUnitOfWork
    {
        IDataRepository DataRepository { get; }

        int Commit();
        Task<int> CommitAsync(CancellationToken cancellationToken = default);

        void Rollback();
        Task RollbackAsync();
    }
}
