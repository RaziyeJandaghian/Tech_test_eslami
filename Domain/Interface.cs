using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IWalletRepository
    {
        Task<Wallet> GetWalletByIdAsync(Guid walletId);
        Task UpdateWalletAsync(Wallet wallet);
        Task AddWalletAsync(Wallet wallet);
    }

    public interface ITransactionRepository
    {
        Task AddTransactionAsync(Transaction transaction);
        Task<IEnumerable<Transaction>> GetTransactionsByWalletIdAsync(Guid walletId);
    }
}
