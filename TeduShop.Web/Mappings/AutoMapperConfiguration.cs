﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TeduShop.Web.Models;
using TeduShop.Model.Models;

namespace TeduShop.Web.Mappings
{
  public class AutoMapperConfiguration
  {
    public static void Configure()
    {
      Mapper.Initialize(cfg =>
      {
        cfg.CreateMap<Post, PostViewModel>();
        cfg.CreateMap<PostCategory, PostCategoryViewModel>();
        cfg.CreateMap<Tag, TagViewModel>();
      });
    }
  }
}