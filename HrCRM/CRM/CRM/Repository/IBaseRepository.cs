using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public interface IBaseRepository<T, R>
    {
        Task<Int32> SaveAsync(R Value);
        Task SaveAllAsync(IEnumerable<R> Values);
        Task<R> FindByIdAsync(T Id);
        Task DeleteAsync(T Id);
    }
}