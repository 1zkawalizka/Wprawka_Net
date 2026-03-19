using Microsoft.EntityFrameworkCore;
using EventTickets.Models;
 
namespace EventTickets.Data
{
    public class EventData : DbContext
    {
        public EventData(DbContextOptions<EventData> options)
            : base(options) { }

        public DbSet<Event> Events => Set<Event>();
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderI> OrderIs => Set<OrderI>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.Price).HasColumnType("real");

            modelBuilder.Entity<Ticket>()
                .Property(t => t.Price).HasColumnType("real");

            modelBuilder.Entity<OrderI>()
                .Property(oi => oi.price_per_ticket).HasColumnType("real");
        }
    }
}


