﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
  public interface IPostRepository
  {

  }
  public class PostRepository : RepositoryBase<Post>, IPostRepository
  {
    public PostRepository(DbFactory dbFactory)
      : base(dbFactory)
    {

    }
  }
}
