using Microsoft.EntityFrameworkCore;
using Mission.Entities.Models;
using System.Collections.Generic;

namespace Mission.Entities
{
    public class MissionDbContext(DbContextOptions<MissionDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MissionSkill> MissionSkills { get; set; }
        public DbSet<MissionTheme> MissionThemes { get; set; }

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