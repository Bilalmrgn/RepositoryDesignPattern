using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    //bu interface sadece read işlemlerini yapacak (read = getAll, GetById, ...)
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingle(Expression<Func<T, bool>> method);//Expression = x => x.Select koşullarını yapmamızı sağlayacak fonksiyondur
        Task<T> GetByIdAsync(string id);

        /*
         IQueryable yazmamızın nedeni şudur:
            biz eğer sorgu üzerinde çalışacaksak IQueryable yazmamız gerekiyor eğer burada List yazarsak bu IEnumerable dir ve bu işlemleri InMemory'de yapar
            yani diyelim ki veritabanımda 1 milyon kayıt var. Ben eğer List dersem bu 1 milyon kaydı RAM'e yükler ve buradan sonra filtreleme ya da listeleme yapar
            ama IQueryable dersem bu veritabanından sadece gerekli kısımları getirir.
         */
    }
}
