using System;

namespace Shop_Data.Infastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDbContext Init();
    }
}