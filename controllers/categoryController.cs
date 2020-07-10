using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simpleapi.data;
using simpleapi.model;

namespace simpleapi.controllers{
    [ApiController]
    [Route("v1/categories")]
    public class CatergoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get ([FromServices] Datacontext context)
        {
            var categories=await context.Categories.ToListAsync();
            return categories;

        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post(
            [FromServices] Datacontext context,
            [FromBody]Category model
        )
        {
            if(ModelState.IsValid){
                context.Categories.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else{
                return BadRequest(ModelState);
            }

        }
    }
}