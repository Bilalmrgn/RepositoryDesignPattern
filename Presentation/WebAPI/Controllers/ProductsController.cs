using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _writeRepository;
        private readonly IProductReadRepository _readRepository;
        public ProductsController(IProductWriteRepository writeRepository, IProductReadRepository readRepository)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
        }

        public async void Get()
        {
            _writeRepository.AddRangeAsync(new()
            {
                new(){Id =  1, Name ="bilal",Price=100,CreatedDate=DateTime.Now,Stock = 4}
                new(){Id =  1, Name ="bilal",Price=100,CreatedDate=DateTime.Now,Stock = 4}
                new(){Id =  1, Name ="bilal",Price=100,CreatedDate=DateTime.Now,Stock = 4}
            });
            await _writeRepository.SaveChangeAsync();
        }





    }
}
