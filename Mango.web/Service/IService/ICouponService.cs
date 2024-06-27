using Mango.web.Models;

namespace Mango.web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto> GetCouponAsync(string couponCode);
        Task<ResponseDto> GetAllCouponAsync();
        Task<ResponseDto> GetCouponByIdAsync(int id);
        Task<ResponseDto> CreateCouponsAsync(CouponDto coupon);
        Task<ResponseDto> UpdateCouponAsync(CouponDto coupon);
        Task<ResponseDto> DeleteCouponAsync(int id);
    }
}
