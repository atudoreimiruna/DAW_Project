using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proiect1.DAL.Configuration;
using Proiect1.DAL.Configurations;
using Proiect1.DAL.Entities;
using System;

namespace Proiect1.DAL
{
    public class AppDbContext : IdentityDbContext<
        User,
        Role,
        int,
        IdentityUserClaim<int>,
        UserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>>

    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Designer> Designers { get; set; }
        public DbSet<DesignerAddress> DesignerAddresses { get; set; }
        public DbSet<DesignerAward> DesignerAwards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DesignerClient> DesignerClients { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<DesignerCollection> DesignerCollections { get; set; }
        public DbSet<CollectionFactory> CollectionFactories { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; } 
        public DbSet<Feedback> Feedbacks { get; set; }

       /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(options => options.AddConsole()));
        }
       */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DesignerConfiguration());
            modelBuilder.ApplyConfiguration(new DesignerAddressConfiguration());
            modelBuilder.ApplyConfiguration(new DesignerAwardConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new DesignerClientConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionConfiguration());
            modelBuilder.ApplyConfiguration(new DesignerCollectionConfiguration());
            modelBuilder.ApplyConfiguration(new CollectionFactoryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientAddressConfiguration());
            modelBuilder.ApplyConfiguration(new NewsLetterConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
        }

        
        public Designer Find(Designer id)
        {
            throw new NotImplementedException();
        }
    }
}
