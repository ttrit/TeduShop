namespace TeduShop.Data.Infrastructure
{
  public class DbFactory : Dispoable, IDbFactory
  {
    TeduShopDbContext dbContext;

    public TeduShopDbContext Init()
    {
      return dbContext ?? (dbContext = new TeduShopDbContext());
    }

    protected override void DisposeCore()
    {
      if (dbContext != null)
        dbContext.Dispose();
      {

      }
    }
  }
}
