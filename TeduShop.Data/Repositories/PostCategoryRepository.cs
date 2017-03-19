using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
  public interface IPostCateogoryRepository
  {

  }
  public class PostCategoryRepository : RepositoryBase<ProductCategory>, IPostCateogoryRepository
  {
    public PostCategoryRepository(DbFactory dbFactory)
      : base(dbFactory)
    {

    }
  }
}
