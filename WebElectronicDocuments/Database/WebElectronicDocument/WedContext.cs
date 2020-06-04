using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Database
{
    public class WedContext : DbContext
    {
        // Scaffold-DbContext "Server=KHARISOV\SQLEXPRESS02;Database=2c;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database\_2C
        // Scaffold-DbContext "Server=KHARISOV\SQLEXPRESS02;Database=2c;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database\_2C -f 

        // Add-Migration AddUser -Context WedContext -OutputDir Migrations\Wed
        // Update-Database -Context WedContext
        public WedContext() { }
        public WedContext(DbContextOptions<WedContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stage>().HasData(
                new Stage[] 
                {
                    new Stage() { Id = 1, Name = "Исполнитель", Color = "blue" },
                    new Stage() { Id = 2, Name = "Нормоконтроль", Color = "orange" },
                    new Stage() { Id = 3, Name = "Директор", Color = "brown" },
                    new Stage() { Id = 4, Name = "СМК", Color = "green" }
                }
                );
        }

        public DbSet<Stage> Stages { get; set; }
        public DbSet<DocJournal> DocJournals { get; set; }
        public DbSet<DocAction> DocActions { get; set; }
        public DbSet<UserJournal> UserJournals { get; set; }
        public DbSet<DocFile> DocFiles { get; set; }
    }
}
