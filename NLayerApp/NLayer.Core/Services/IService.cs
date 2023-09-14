using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        // İkisi de Generic oldukları için repo katmanıyla aynı kodlar yazılıyor 

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync(); //Bu satır farklı onu da farklılık olsun diye kursta değiştiriyor.


        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        Task <IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);

        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
