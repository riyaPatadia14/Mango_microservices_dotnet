using AutoMapper;
using Mango.Api.Models;
using Mango.Api.Models.Dto;

namespace Mango.Api.Configuration
{
    public class Mapping : Profile
    {
        public static MapperConfiguration RegisterMapping()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
