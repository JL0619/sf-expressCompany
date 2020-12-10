using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
