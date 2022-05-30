using CrudOperations.API.Models;
using CrudOperations.API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudOperations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Fields

        private readonly ProductRepository _productRepo;

        #endregion

        #region Constructors

        public ProductController(ProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        #endregion

        #region Methods

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepo.GetAll();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _productRepo.GetById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Task Post([FromBody] Product product)
        {
            return _productRepo.Add(product);
        }

        // PUT api/<ProductController>
        [HttpPut]
        public Task Put([FromBody] Product product)
        {
            return  _productRepo.Edit(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
           return _productRepo.Del(id);
        }
        #endregion
    }
}
