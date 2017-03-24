﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;
using TeduShop.Data.Infrastructure;
using System.Reflection;
using TeduShop.Data;
using TeduShop.Data.Repositories;
using TeduShop.Service;
using System.Web.Mvc;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartup(typeof(TeduShop.Web.App_Start.Startup))]

namespace TeduShop.Web.App_Start
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigAutofac(app);
    }

    private void ConfigAutofac(IAppBuilder app)
    {
      var builder = new ContainerBuilder();
      builder.RegisterControllers(Assembly.GetExecutingAssembly());
      // Register your Web API controllers.
      builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

      builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
      builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

      builder.RegisterType<TeduShopDbContext>().AsSelf().InstancePerRequest();

      // Repositories
      builder.RegisterAssemblyTypes(typeof(PostCategoryRepository).Assembly)
        .Where(t => t.Name.EndsWith("Repository"))
        .AsImplementedInterfaces().InstancePerRequest();

      // Services
      builder.RegisterAssemblyTypes(typeof(PostCategoryService).Assembly)
        .Where(t => t.Name.EndsWith("Service"))
        .AsImplementedInterfaces().InstancePerRequest();

      Autofac.IContainer container = builder.Build();
      DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

      GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
    }
  }
}
