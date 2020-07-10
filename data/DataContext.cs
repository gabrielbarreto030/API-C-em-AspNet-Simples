using Microsoft.EntityFrameworkCore;
using simpleapi.model;

namespace simpleapi.data{
    public class Datacontext : DbContext{
         public Datacontext(DbContextOptions<Datacontext> options) : base(options)
         {

         }
         public DbSet<Products> Products { get;set; }
         public DbSet<Category> Categories { get;set; }      
    }
}