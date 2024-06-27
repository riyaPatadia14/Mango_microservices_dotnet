namespace Mango.AuthAPI.Data
{
    public class MangosDBContext : IdentityDbContext<IdentityUser>
    {
        public MangoDBContext(DbContextOptions<MangoDBContext> options) : base(options) { }

        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount = 20,
                MinAmount = 10
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
                DiscountAmount = 20,
                MinAmount = 40
            });

        }
    }
}
