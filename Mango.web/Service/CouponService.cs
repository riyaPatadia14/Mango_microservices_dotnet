using Mango.web.Models;
using Mango.web.Service.IService;
using Mango.web.Utility;

namespace Mango.web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto> CreateCouponsAsync(CouponDto coupon)
        {
            var addCouponData = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.POST,
                Data= coupon,
                Url = StaticDetails.CouponAPIBase + "/api/coupon" 
            });
            return addCouponData;
        }

        public async Task<ResponseDto> DeleteCouponAsync(int id)
        {
            var deleteCouponById = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.DELETE,
                Url = StaticDetails.CouponAPIBase + "/api/coupon?id=" + id
            });
            return deleteCouponById;
        }

        public async Task<ResponseDto> GetAllCouponAsync()
        {
            var getAllResponse = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
            return getAllResponse;
        }

        public async Task<ResponseDto> GetCouponAsync(string couponCode)
        {
            var getCouponCode = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
            return getCouponCode;
        }

        public async Task<ResponseDto> GetCouponByIdAsync(int id)
        {
            var getCouponbyId = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.GET,
                Url = StaticDetails.CouponAPIBase + "/api/coupon/" + id
            });
            return getCouponbyId;
        }

        public async Task<ResponseDto> UpdateCouponAsync(CouponDto coupon)
        {
            var updateCouponData = await _baseService.SendAsync(new RequestDto()
            {
                ApiType = StaticDetails.ApiType.PUT,
                Data = coupon,
                Url = StaticDetails.CouponAPIBase + "/api/coupon"
            });
            return updateCouponData;
        }
    }
}
