using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Autofac.Extensions.DependencyInjection;
using Autofac.Features.Variance;
using Common;
<<<<<<< HEAD
=======
using Data;
using Data.Repositories;
using Entities;
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace WebFramework.Configuration
{
    internal class AllConstructorFinder : IConstructorFinder
    {
        private static readonly ConcurrentDictionary<Type, ConstructorInfo[]> Cache = new ConcurrentDictionary<Type, ConstructorInfo[]>();

        public ConstructorInfo[] FindConstructors(Type targetType)
        {
            var result = Cache.GetOrAdd(targetType, t => t.GetTypeInfo().DeclaredConstructors.ToArray());
            return result.Length > 0 ? result : throw new NoConstructorsFoundException(targetType);
        }
    }

<<<<<<< HEAD
 
=======
    //internal static class Assemblies
    //{
    //    public static readonly Assembly Application = typeof(GetCartQueryHandler).Assembly;
    //}

    //public class MediatorModule : Autofac.Module
    //{
    //    protected override void Load(ContainerBuilder builder)
    //    {
    //        builder.RegisterSource(new ScopedContravariantRegistrationSource(typeof(IRequestHandler<,>), typeof(INotificationHandler<>), typeof(IValidator<>)));
    //        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

    //        var mediatrOpenTypes = new[]
    //        {
    //        typeof(IRequestHandler<,>),
    //        //typeof(INotificationHandler<>),
    //        typeof(IValidator<>)
    //    };

    //        foreach (var mediatrOpenType in mediatrOpenTypes)
    //        {
    //            builder
    //                .RegisterAssemblyTypes(Assemblies.Application, ThisAssembly)
    //                .AsClosedTypesOf(mediatrOpenType)
    //                .FindConstructorsWith(new AllConstructorFinder())
    //                .AsImplementedInterfaces();
    //        }

    //        ////////builder.RegisterGeneric(typeof(RequestPostProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
    //        ////////builder.RegisterGeneric(typeof(RequestPreProcessorBehavior<,>)).As(typeof(IPipelineBehavior<,>));

    //        builder.Register<ServiceFactory>(ctx =>
    //        {
    //            var c = ctx.Resolve<IComponentContext>();
    //            return t => c.Resolve(t);
    //        });

    //        builder.RegisterGeneric(typeof(CommandValidationBehavior<,>)).As(typeof(IPipelineBehavior<,>));
    //    }

    //    private class ScopedContravariantRegistrationSource : IRegistrationSource
    //    {
    //        private readonly IRegistrationSource _source = new ContravariantRegistrationSource();
    //        private readonly List<Type> _types = new List<Type>();

    //        public ScopedContravariantRegistrationSource(params Type[] types)
    //        {
    //            if (types == null)
    //                throw new ArgumentNullException(nameof(types));
    //            if (!types.All(x => x.IsGenericTypeDefinition))
    //                throw new ArgumentException("Supplied types should be generic type definitions");
    //            _types.AddRange(types);
    //        }

    //        public IEnumerable<IComponentRegistration> RegistrationsFor(
    //            Service service,
    //            Func<Service, IEnumerable<ServiceRegistration>> registrationAccessor)
    //        {
    //            var components = _source.RegistrationsFor(service, registrationAccessor);
    //            foreach (var c in components)
    //            {
    //                var defs = c.Target.Services
    //                    .OfType<TypedService>()
    //                    .Select(x => x.ServiceType.GetGenericTypeDefinition());

    //                if (defs.Any(_types.Contains))
    //                    yield return c;
    //            }
    //        }
    //        public bool IsAdapterForIndividualComponents => _source.IsAdapterForIndividualComponents;
    //    }
    //}

    public class DataAccessModule : Autofac.Module
    {
        private readonly string _databaseConnectionString;

        public DataAccessModule(string databaseConnectionString)
        {
            _databaseConnectionString = databaseConnectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SqlConnectionFactory>()
                .As<ISqlConnectionFactory>()
                .WithParameter("connectionString", _databaseConnectionString)
                .InstancePerLifetimeScope();

            //builder.RegisterType<UnitOfWork>()
            //    .As<IUnitOfWork>()
            //    .InstancePerLifetimeScope();


            //builder.RegisterType<CustomerRepository>()
            //    .As<ICustomerRepository>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<ProductRepository>()
            //    .As<IProductRepository>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<PaymentRepository>()
            //    .As<IPaymentRepository>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<StronglyTypedIdValueConverterSelector>()
            //    .As<IValueConverterSelector>()
            //    .InstancePerLifetimeScope();

            builder
                .Register(c =>
                {
                    var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                    dbContextOptionsBuilder.UseSqlServer(_databaseConnectionString);
                    //dbContextOptionsBuilder
                    //    .ReplaceService<IValueConverterSelector, StronglyTypedIdValueConverterSelector>();

                    return new ApplicationDbContext(dbContextOptionsBuilder.Options);
                })
                .AsSelf()
                .As<DbContext>()
                .InstancePerLifetimeScope();
        }
    }

    public class SqlConnectionFactory : ISqlConnectionFactory, IDisposable
    {
        private readonly string _connectionString;
        private IDbConnection _connection;

        public SqlConnectionFactory(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public IDbConnection GetOpenConnection()
        {
            if (this._connection == null || this._connection.State != ConnectionState.Open)
            {
                this._connection = new SqlConnection(_connectionString);
                this._connection.Open();
            }

            return this._connection;
        }

        public void Dispose()
        {
            if (this._connection != null && this._connection.State == ConnectionState.Open)
            {
                this._connection.Dispose();
            }
        }
    }
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c

 
    public static class AutofacConfigurationExtensions
    {
        public static void AddServices(this ContainerBuilder containerBuilder)
        {
<<<<<<< HEAD
            ////RegisterType > As > Lifetime
            //containerBuilder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            //containerBuilder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            //// رویس زرین پال بابت درگاه
            //containerBuilder.RegisterType<ZarrinpalPaymentService>().As<IZarrinpalPaymentService>().InstancePerLifetimeScope();
=======
            //RegisterType > As > Lifetime
            containerBuilder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
     
 
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c

            var commonAssembly = typeof(SiteSettings).Assembly;
            //var entitiesAssembly = typeof(IEntity).Assembly;

<<<<<<< HEAD
            //var dataAssembly = typeof(ApplicationDbContext).Assembly;
            //var servicesAssembly = typeof(IDataInitializer).Assembly;
            //var BLAssembly = typeof(IBL).Assembly;

            containerBuilder.RegisterAssemblyTypes(commonAssembly)//, entitiesAssembly, dataAssembly, servicesAssembly, BLAssembly)
=======
            var dataAssembly = typeof(ApplicationDbContext).Assembly;
            //var servicesAssembly = typeof(IDataInitializer).Assembly;
            //var BLAssembly = typeof(IBL).Assembly;

            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly)//, servicesAssembly, BLAssembly)
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c
                .AssignableTo<IScopedDependency>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

<<<<<<< HEAD
            containerBuilder.RegisterAssemblyTypes(commonAssembly)//, entitiesAssembly, dataAssembly, servicesAssembly, BLAssembly)
=======
            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly)//, servicesAssembly, BLAssembly)
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c
                .AssignableTo<ITransientDependency>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

<<<<<<< HEAD
            containerBuilder.RegisterAssemblyTypes(commonAssembly)//, entitiesAssembly, dataAssembly, servicesAssembly, BLAssembly)
=======
            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly)//, servicesAssembly, BLAssembly)
>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c
                .AssignableTo<ISingletonDependency>()
                .AsImplementedInterfaces()
                .SingleInstance();
        }

        public static IServiceProvider BuildAutofacServiceProvider(this IServiceCollection services, IConfiguration configuration)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);

            //Register Services to Autofac ContainerBuilder
            containerBuilder.AddServices();
<<<<<<< HEAD
 
=======

            //containerBuilder.RegisterModule(new MediatorModule());
            containerBuilder.RegisterModule(new DataAccessModule(configuration.GetConnectionString("SqlServer")));

>>>>>>> ff23e34d51b0d49cb2135baa86697bda99b0e30c
            var container = containerBuilder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}