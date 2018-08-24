using DG.API.ENTITY.Models.Authorize;
using DG.API.SERVICE;
using DG.API.SERVICE.Authorize.AuUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace DG.API.App_Start
{
    public static class UnityConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            container.RegisterType<IRepository<SYS_USER>, Repository<SYS_USER>>();
            container.RegisterType<IAuUserService, AuUserService>();

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}