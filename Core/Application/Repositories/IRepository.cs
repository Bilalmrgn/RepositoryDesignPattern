using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Entity {  get; } //Repository yani concrete sınıfta sürekli _context.Set<T> yazmamak için bu şekilde yazdık
        Task AddAsync(T entity);//asenkron çalışmak için task yazdık
        Task Update(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllById(int id);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        /*
         IQueryable yazmamızın nedeni şudur:
            biz eğer sorgu üzerinde çalışacaksak IQueryable yazmamız gerekiyor eğer burada List yazarsak bu IEnumerable dir ve bu işlemleri InMemory'de yapar
            yani diyelim ki veritabanımda 1 milyon kayıt var. Ben eğer List dersem bu 1 milyon kaydı RAM'e yükler ve buradan sonra filtreleme ya da listeleme yapar
            ama IQueryable dersem bu veritabanından sadece gerekli kısımları getirir.
         */



    }
}
