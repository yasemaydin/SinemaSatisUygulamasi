using YaseminAydın.Models;
using Microsoft.EntityFrameworkCore;
namespace YaseminAydın
{
    public partial class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<Salon> Salon { get; set; }
        public virtual DbSet<Seans> Seans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=YaseminAydın.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("Film");
                entity.HasKey(e => e.id);
                entity.Property(e => e.FilmAd).HasColumnType("TEXT");
                entity.Property(e => e.Seans1).HasColumnType("DATETIME");
                entity.Property(e => e.Seans2).HasColumnType("DATETIME");
                entity.Property(e => e.Seans3).HasColumnType("DATETIME");
            });
            modelBuilder.Entity<Salon>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.SalonAd).HasColumnType("TEXT");
                entity.Property(e => e.Kapasite).HasColumnType("INTEGER");
            });
            modelBuilder.Entity<Seans>(entity => {
                entity.HasKey(e => e.id);
                entity.Property(e => e.FilmAd).HasColumnType("TEXT");
                entity.Property(e => e.Tarih).HasColumnType("DATETIME");
                entity.Property(e => e.Salon).HasColumnType("TEXT");
                entity.Property(e => e.MusteriAd).HasColumnType("TEXT");
                entity.Property(e => e.MusteriSoyad).HasColumnType("TEXT");
                entity.Property(e => e.KimlikNo).HasColumnType("TEXT");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}