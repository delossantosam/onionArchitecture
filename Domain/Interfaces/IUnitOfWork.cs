using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // IDeveloperRepository Developers { get; }
        IProductRepository Product { get; }
        int Complete();
        Task<int> CompleteAsync();
    }
}
