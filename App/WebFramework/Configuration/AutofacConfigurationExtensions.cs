using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Autofac.Extensions.DependencyInjection;
using Autofac.Features.Variance;
using Common;
using Data;
using Data.Repositories;
using Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using WebFramework.RabbitMQ;

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

            //builder
            //    .Register(c =>
            //    {
            //        var dbContextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //        dbContextOptionsBuilder.UseSqlServer(_databaseConnectionString);
            //        //dbContextOptionsBuilder
            //        //    .ReplaceService<IValueConverterSelector, StronglyTypedIdValueConverterSelector>();

            //        return new ApplicationDbContext(dbContextOptionsBuilder.Options);
            //    })
            //    .AsSelf()
            //    .As<DbContext>()
            //    .InstancePerLifetimeScope();
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
    public static class AutofacConfigurationExtensions
    {
        public static void AddServices(this ContainerBuilder containerBuilder)
        {
            //RegisterType > As > Lifetime
            containerBuilder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();






            var commonAssembly = typeof(SiteSettings).Assembly;
            var entitiesAssembly = typeof(IEntity).Assembly;

            var dataAssembly = typeof(ApplicationDbContext).Assembly;
            //var servicesAssembly = typeof(IDataInitializer).Assembly;
            //var BLAssembly = typeof(IBL).Assembly;
            var webFrameworkAssembly = typeof(IRpcClientQueue).Assembly;
             
         
            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly, webFrameworkAssembly)//, servicesAssembly, BLAssembly)
                .AssignableTo<IScopedDependency>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly, webFrameworkAssembly)//, servicesAssembly, BLAssembly)
                .AssignableTo<ITransientDependency>()
                .AsImplementedInterfaces()
                .InstancePerDependency();

            containerBuilder.RegisterAssemblyTypes(commonAssembly, entitiesAssembly, dataAssembly, webFrameworkAssembly)//, servicesAssembly, BLAssembly)
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


            containerBuilder.RegisterType<SqlConnectionFactory>()
               .As<ISqlConnectionFactory>()
               .WithParameter("connectionString", configuration.GetConnectionString("SqlServer"))
               .InstancePerLifetimeScope();
            //containerBuilder.RegisterModule(new MediatorModule());
            //containerBuilder.RegisterModule(new DataAccessModule(configuration.GetConnectionString("SqlServer")));

            var container = containerBuilder.Build();

            return new AutofacServiceProvider(container);
        }
    }
}