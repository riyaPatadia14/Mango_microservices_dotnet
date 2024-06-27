using Mango.web.Service;
using Mango.web.Service.IService;
using Mango.web.Utility;

namespace Mango.web.IOCConainer
{
    public static class ContextRegistery
    {
        public static void RegisterContainer(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddHttpContextAccessor();
            service.AddHttpClient();
            service.AddHttpClient<ICouponService, CouponService>();
            StaticDetails.CouponAPIBase = configuration["ServiceUrls:CouponAPI"];
            service.AddScoped<IBaseService, BaseService>();
            service.AddScoped<ICouponService, CouponService>();
        }
    }
}