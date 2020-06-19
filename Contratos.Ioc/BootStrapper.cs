using Autofac;
using AutoMapper;
using Contratos.Data.Contexto;
using Contratos.Repositories.Interfaces;
using Contratos.Repositories.Repository;
using Contratos.Services;
using Contratos.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Contratos.Ioc
{
    public static class BootStrapper
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            #region Context
            builder.RegisterType<ContratosContexto>()
                .AsSelf()
                .InstancePerRequest();
            #endregion

            #region automapper
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
                .As<Profile>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>()
                .CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
            #endregion

            #region Services
            builder.SetarVidaUtilInstancia<IClienteService, ClienteService>();
            builder.SetarVidaUtilInstancia<IContratoService, ContratoService>();
            builder.SetarVidaUtilInstancia<IUsuarioService, UsuarioService>();
            #endregion

            #region Repositories
            builder.SetarVidaUtilInstancia<IClienteRepository, ClienteRepository>();
            builder.SetarVidaUtilInstancia<IContratoRepository, ContratoRepository>();
            builder.SetarVidaUtilInstancia<IUsuarioRepository, UsuarioRepository>();

            
            #endregion Repositories
        }

        public static void SetarVidaUtilInstancia<T, E>(this ContainerBuilder builder)
        {
            builder.RegisterType<E>().AsSelf().As<T>().InstancePerRequest();
        }
    }
}
