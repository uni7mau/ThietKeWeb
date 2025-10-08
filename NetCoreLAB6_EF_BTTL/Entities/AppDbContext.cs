using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF_BTTL.Models;

namespace NetCoreLAB6_EF_BTTL.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<StdClass> StdClasses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Khóa chính kép cho bảng Marks
            modelBuilder.Entity<Mark>()
                .HasKey(m => new { m.SubjectId, m.StudentId });

            // Quan hệ 1–N giữa StdClass và Student
            modelBuilder.Entity<StdClass>()
                .HasMany(c => c.Students)
                .WithOne(s => s.StdClass)
                .HasForeignKey(s => s.ClassId);

            // Quan hệ N–N giữa Student và Subject qua Marks
            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Student)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.StudentId);

            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Subject)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.SubjectId);
        }
    }
}
