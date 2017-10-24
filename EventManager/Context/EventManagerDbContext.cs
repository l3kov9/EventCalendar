namespace EventManager.Context
{
    using EventManager.Models;
    using System.Data.Entity;

    public class EventManagerDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
