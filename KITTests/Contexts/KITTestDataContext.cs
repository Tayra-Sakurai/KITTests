using KITTests.Models;
using Microsoft.EntityFrameworkCore;

namespace KITTests.Contexts
{
    public class KITTestDataContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TestData> TestData { get; set; }

        public KITTestDataContext(DbContextOptions<KITTestDataContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasServiceTier("Free");
            modelBuilder.HasDatabaseMaxSize("32 GB");

            modelBuilder.Entity<Subject>(t =>
            {
                t.ToTable("Subjects");
                t.HasMany(e => e.TestData)
                .WithOne(e => e.Subject)
                .IsRequired();
            });
            modelBuilder.Entity<TestData>(t =>
            {
                t.Property(e => e.Date)
                .IsRequired();
                t.Property(e => e.ExamDate)
                .IsRequired();
            });
        }
    }
}
