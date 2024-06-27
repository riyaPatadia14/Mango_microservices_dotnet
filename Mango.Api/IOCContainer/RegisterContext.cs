using AutoMapper;
using Mango.Api.Configuration;
using Mango.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Mango.Api.IOCContainer
{
    public static class RegisterContext
    {
        public static void RegisterContainer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MangoDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MangoConnection"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            IMapper mapper = Mapping.RegisterMapping().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}