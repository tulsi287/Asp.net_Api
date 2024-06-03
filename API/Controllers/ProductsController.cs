using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
       
        private readonly StoreConext _conext;
        
        public ProductsController(StoreConext conext)
        {
            _conext = conext;
            
            
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _conext.Products.ToListAsync();
        }   
        [HttpGet("{id}")]//api/products/id

        public async Task<ActionResult<Product>>GetProduct(int id)
        {
            return await _conext.Products.FindAsync(id);
        }
    }
}