using Microsoft.EntityFrameworkCore;
using OnlineShop_Mvp.Models.DomainModels.OrderAggregates;
using OnlineShop_Mvp.Models.DomainModels.PersonAggregates;
using OnlineShop_Mvp.Models.DomainModels.ProductAggregate;
using OnlineShop_Mvp.Services.Dtos.ProductDtos;

namespace OnlineShop_Mvp.Models
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions Options) : base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.Id);


            modelBuilder.Entity<Person>().HasKey(x => x.Id);



            modelBuilder.Entity<OrderHeader>().HasKey(x => x.ID);

            modelBuilder.Entity<OrderDetail>().HasKey(option => new { option.ProductID, option.OrderHeaderID });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product_Detail_Dto> Product_Detail_Dto { get; set; }
        public DbSet<Product_Edit_Dto> Product_Edit_Dto { get; set; }
    }
}
