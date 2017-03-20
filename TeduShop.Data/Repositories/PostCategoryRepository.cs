using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
  public interface IPostCateogoryRepository : IRepository<PostCategory>
  {

  }
  public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCateogoryRepository
  {
    public PostCategoryRepository(DbFactory dbFactory)
      : base(dbFactory)
    {

    }
  }
}
