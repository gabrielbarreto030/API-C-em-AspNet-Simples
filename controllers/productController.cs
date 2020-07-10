using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleapi.data;
using simpleapi.model;

namespace simpleapi.controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductControlles : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Products>>> Get([FromServices] Datacontext context)
        {

            var products = await context.Products.Include(x => x.Category).ToListAsync();
            return products;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Products>> GetById([FromServices] Datacontext context, int id)
        {
            var products = await context.Products.Include(x => x.Category).
            AsNoTracking()
            .FirstOrDefaultAsync(x => x.id == id);
            return products;
        }
        [HttpGet]
        [Route("categories/{id:int}")]
        public async Task<ActionResult<List<Products>>> GetByCategories([FromServices] Datacontext context, int id)
        {
            var product = await context.Products.Include(x => x.Category)
            .AsNoTracking()
            .Where(x => x.CategoryId == id).ToListAsync();
            return product;
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Products>> Post([FromServices] Datacontext context,[FromBody]Products model)
        {
            if(ModelState.IsValid)
            {
              context.Products.Add(model);
              await context.SaveChangesAsync();
              return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}