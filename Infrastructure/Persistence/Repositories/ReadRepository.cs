using Application.Repositories;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;

        //GetById methoduna dikkat etmemiz gerekiyor. Çünkü burada generic yapıyla çalışma yaptığımız için string id de direkt id değerini alamıyoruz.
        //bunun için yapmamız gereken işlem şu: BaseEntity yazıp where T : Class yazdığımız yere artık BaseEntity yazacağız çünkü BaseEntity de bir class tır. -->
        //--> bu şekilde repository de class ı kesinleştirmiş oluruz ve ID yi de parametre olarak alabiliriz.
        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(data => data.Id == id);

        public async Task<T> GetSingle(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        //burada sadece methodu veririz çünkü biz interface de şu şekilde bir tanımlama yapmıştık: Task<T> GetSingle(Expression<Func<T, bool>> method);
        // yani firstOrDefault da zaten bizden Task<T> GetSingle(Expression<Func<T, bool>> method); bu şekilde bir ifade ister 

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
    }
}
