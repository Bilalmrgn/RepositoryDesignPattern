using Application.Repositories;
using Domain;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {

        // Eğer miras aldığımız (parent) sınıfın bir constructor’ı varsa,
        // child class oluşturulurken o constructor’ın da çalıştırılması gerekir.
        // Bu nedenle base(context) kullanarak parent constructor’ını çağırıyoruz.
        // Aksi halde parent sınıf doğru şekilde initialize edilmez.
        public OrderReadRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<Order>> GetOrdersByCustomerIdAsync(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
