using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    //bu sınıfın amacı ekleme silme güncelleme vs sınıfları içindir
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);//Addasync 1 tane işlem ekler. Koleksyon şeklinde eklemek istiyorsak List yazmamız gerekir
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<T> model);
        bool Update(T model);
        Task<int> SaveChangeAsync();
    }
}
