using Microsoft.EntityFrameworkCore;
using Mission.Entities.Models;
using System.Collections.Generic;

namespace Mission.Entities
{
    public class MissionDbContext(DbContextOptions<MissionDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegancyTimestampBehavior", true);

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "nitin",
                LastName = "parmar",
                EmailAddress = "nitinparmar@gmail.com",
                Password = "nitin",
                PhoneNumber = "01234567890",
                UserType = "admin",
            });

            base.OnModelCreating(modelBuilder);

        }
    }
}