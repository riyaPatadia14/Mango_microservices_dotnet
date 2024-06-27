using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Mango.web.Utility
{
    public class StaticDetails
    {
        public static string CouponAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
