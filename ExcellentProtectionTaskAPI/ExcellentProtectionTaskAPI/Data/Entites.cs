using ExcellentProtectionTaskAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcellentProtectionTaskAPI.Data
{
    public class Entites : DbContext
    {
        public Entites():base(){}
        public Entites(DbContextOptions options):base(options){}
        public  DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderPayment> OrdersPayment { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderPayment>()
           .HasKey(OP => new {OP.PaymentId,OP.OrderId});
            modelBuilder.Entity<OrderPayment>()
                      .HasOne(OP => OP.order)
                      .WithMany(O => O.payments)
                      .HasForeignKey(OP => OP.OrderId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .IsRequired(false);
            modelBuilder.Entity<OrderPayment>()
                      .HasOne(OP => OP.payment)
                      .WithMany(P => P.orders)
                      .HasForeignKey(OP => OP.PaymentId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .IsRequired(false);
            modelBuilder.Entity<Payment>()
                      .Property(P => P.Date)
                      .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<OrderPayment>()
                     .Property(OP => OP.Date)
                     .HasDefaultValue(DateTime.Now);
            //modelBuilder.Entity<Payment>()
            //        .Property(P => P.Paid)
            //        .HasDefaultValue(0.0);
            //modelBuilder.Entity<Payment>()
            //        .Property(P => P.Rest)
            //        .HasDefaultValue(0.0);
            modelBuilder.Entity<Order>()
                     .Property(O => O.TotalPrice)
                     .HasComputedColumnSql("Price * Quantity");
            modelBuilder.Entity<Order>()
                     .Property(O => O.Paid)
                     .HasComputedColumnSql("dbo.getOrdersPaid([Id])");
            modelBuilder.Entity<Order>()
                     .Property(O => O.Rest)
                     .HasComputedColumnSql("dbo.getRest([Id])");
            modelBuilder.Entity<Order>()
                     .Property(O => O.status)
                     .HasComputedColumnSql("dbo.getOrderStatus([Id])");
            modelBuilder.Entity<Order>()
                    .Property(O => O.TotalPrice)
                    .ValueGeneratedOnAddOrUpdate();
        }
    }
}
