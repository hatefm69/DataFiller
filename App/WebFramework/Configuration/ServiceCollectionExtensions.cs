using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebFramework.Configuration
{
    public static class ServiceCollectionExtensions
    {
        //readonly static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options
                    .UseSqlServer(configuration.GetConnectionString("SqlServer"));//SqlServer
                                                                                  // .ConfigureWarnings(warning => warning.Throw(RelationalEventId.QueryClientEvaluationWarning));

                options.EnableSensitiveDataLogging();

            }, ServiceLifetime.Transient);
        }
        //public static void UseMinimalMvc(this IApplicationBuilder app)
        //{
        //    app.UseCors(
        //                    options => options.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()//("http://example.com").AllowAnyMethod()
        //               );

        //}
        //public static void AddMinimalMvc(this IServiceCollection services)
        //{
        //    //https://github.com/aspnet/Mvc/blob/release/2.2/src/Microsoft.AspNetCore.Mvc/MvcServiceCollectionExtensions.cs
        //    services.AddMvcCore(options =>
        //    {
        //        options.EnableEndpointRouting = false;
        //    })
        //        .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
        //        .AddDataAnnotationsLocalization()
        //        .AddApiExplorer()
        //        //.AddAuthorization()
        //        .AddAuthorization(options =>
        //        {
        //            options.AddPolicy("Authorization", policyCorrectUser =>
        //            {
        //                policyCorrectUser.Requirements.Add(new AuthorizationRequirement());
        //            });
        //        })
        //        .AddFormatterMappings()
        //        .AddDataAnnotations()
        //        .AddNewtonsoftJson(option =>
        //         {
        //             option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        //             option.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

        //             option.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.None;

        //             //option.SerializerSettings.Converters.Add(new JsonStringEnumConverter());

        //             option.SerializerSettings.Converters.Add(new StringEnumConverter { CamelCaseText = true });
        //         })
        //    //.AddJsonOptions(options =>
        //    //{
        //    //    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        //    //    options.JsonSerializerOptions.IgnoreNullValues = true;
        //    //    options.JsonSerializerOptions.WriteIndented = false;
        //    //    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        //    //})

        //    .AddCors(options =>
        //    {
        //        options.AddPolicy(MyAllowSpecificOrigins,
        //            builder =>
        //                //    {
        //                //        //builder.WithOrigins("http://qc.dinavision.org", "https://qc.dinavision.org",
        //                //        //                    "http://www.dinavision.org", "https://www.dinavision.org")
        //                builder.AllowAnyOrigin()
        //                .AllowAnyHeader()
        //                .AllowAnyMethod());

        //        //});
        //    })
        //    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        //}

        //public static void AddElmah(this IServiceCollection services, IConfiguration configuration, SiteSettings siteSetting)
        //{
        //    services.AddElmah<XmlFileErrorLog>(options =>
        //    {
        //        options.Path = siteSetting.ElmahPath;
        //        options.LogPath = "~/Elmahlogs";
        //    });
        //}

        //public static void AddJwtAuthentication(this IServiceCollection services, JwtSettings jwtSettings)
        //{
        //    services.AddAuthentication(options =>
        //    {
        //        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        //    }).AddJwtBearer(options =>
        //    {
        //        var secretkey = Encoding.UTF8.GetBytes(jwtSettings.SecretKey);
        //        var encryptionkey = Encoding.UTF8.GetBytes(jwtSettings.Encryptkey);

        //        var validationParameters = new TokenValidationParameters
        //        {
        //            ClockSkew = TimeSpan.Zero,
        //            RequireSignedTokens = true,

        //            ValidateIssuerSigningKey = true,
        //            IssuerSigningKey = new SymmetricSecurityKey(secretkey),

        //            RequireExpirationTime = true,
        //            ValidateLifetime = true,

        //            ValidateAudience = true,
        //            ValidAudience = jwtSettings.Audience,

        //            ValidateIssuer = true,
        //            ValidIssuer = jwtSettings.Issuer,

        //            TokenDecryptionKey = new SymmetricSecurityKey(encryptionkey)
        //        };

        //        options.RequireHttpsMetadata = false;
        //        options.SaveToken = true;
        //        options.TokenValidationParameters = validationParameters;
        //        options.Events = new JwtBearerEvents
        //        {
        //            /*
        //            OnAuthenticationFailed = context =>
        //            {
        //                //var logger = context.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(JwtBearerEvents));
        //                //logger.LogError("Authentication failed.", context.Exception);

        //                if (context.Exception != null)
        //                    throw new AppException(ApiResultStatusCode.UnAuthorized, "Authentication failed.", HttpStatusCode.Unauthorized, context.Exception, null);

        //                return Task.CompletedTask;
        //            },*/

        //            OnTokenValidated = async context =>
        //            {
        //                var signInManager = context.HttpContext.RequestServices.GetRequiredService<SignInManager<User>>();
        //                var userRepository = context.HttpContext.RequestServices.GetRequiredService<IUserRepository>();

        //                var claimsIdentity = context.Principal.Identity as ClaimsIdentity;
        //                if (claimsIdentity.Claims?.Any() != true)
        //                    context.Fail("This token has no claims.");

        //                var securityStamp = claimsIdentity.FindFirstValue(new ClaimsIdentityOptions().SecurityStampClaimType);
        //                if (!securityStamp.HasValue())
        //                    context.Fail("This token has no secuirty stamp");

        //                //Find user and token from database and perform your custom validation
        //                var userId = claimsIdentity.GetUserId<int>();
        //                var user = await userRepository.GetByIdAsync(context.HttpContext.RequestAborted, userId);

        //                //if (user.SecurityStamp != Guid.Parse(securityStamp))
        //                //    context.Fail("Token secuirty stamp is not valid.");

        //                //var validatedUser = await signInManager.ValidateSecurityStampAsync(context.Principal);
        //                //if (validatedUser == null)
        //                //    context.Fail("Token secuirty stamp is not valid.");
        //                if (user == null)
        //                {
        //                    context.Fail("کاربر یافت نشد.");
        //                    return;
        //                }

        //                if (!user.IsActive)
        //                    context.Fail("User is not active.");

        //                await userRepository.UpdateLastLoginDateAsync(user, context.HttpContext.RequestAborted);
        //            }
        //            /*,
        //            OnChallenge = context =>
        //            {
        //                //var logger = context.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>().CreateLogger(nameof(JwtBearerEvents));
        //                //logger.LogError("OnChallenge error", context.Error, context.ErrorDescription);

        //                if (context.AuthenticateFailure != null)
        //                    throw new AppException(ApiResultStatusCode.UnAuthorized, "Authenticate failure.", HttpStatusCode.Unauthorized, context.AuthenticateFailure, null);
        //                throw new AppException(ApiResultStatusCode.UnAuthorized, "You are unauthorized to access this resource.", HttpStatusCode.Unauthorized);

        //                //return Task.CompletedTask;
        //            }
        //            */
        //        };
        //    });
        //}

        //public static void AddCustomApiVersioning(this IServiceCollection services)
        //{
        //    services.AddApiVersioning(options =>
        //    {
        //        options.AssumeDefaultVersionWhenUnspecified = true;
        //        options.DefaultApiVersion = new ApiVersion(1, 0);
        //        options.ReportApiVersions = true;

        //        ApiVersion.TryParse("1.0", out var version10);
        //        ApiVersion.TryParse("1", out var version1);
        //        var a = version10 == version1;
        //    });
        //}
    }
}
