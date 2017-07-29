namespace Shop_Data.Infastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopDbContext dbContext;

        public ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}