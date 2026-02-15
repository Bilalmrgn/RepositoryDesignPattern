using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IOrderReadRepository : IReadRepository<Order>
    {
        //örneğin aşağıdaki kısım sadece order a özel bir işlemdir
        Task<List<Order>> GetOrdersByCustomerIdAsync(string customerId);
    }
}
