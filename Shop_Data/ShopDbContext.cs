using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Model.Models;

namespace Shop_Data
{
    
    public class ShopDbContext:DbContext
    {
        //const
        public ShopDbContext() : base("ShopDbConnectString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        //khai bao bang
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }

        public DbSet<Test> Tests { get; set; }

        //ghi de phuong thu DBContext: ghi đè
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }

    }
}
