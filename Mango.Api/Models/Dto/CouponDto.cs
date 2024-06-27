using System.ComponentModel.DataAnnotations;

namespace Mango.Api.Models.Dto
{
    public class CouponDto
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponCode { get; set; } = string.Empty;
        [Required]
        public double DiscountAmount { get; set; }
        [Required]
        public int MinAmount { get; set; }
    }
}
