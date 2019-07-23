using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieAPI.DBContext
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
        }

        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MovieGenerics> MovieGenerics { get; set; }
        public virtual DbSet<MovieList> MovieList { get; set; }
        public virtual DbSet<UserIntrestedGenerics> UserIntrestedGenerics { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=movie_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenerics>(entity =>
            {
                entity.ToTable("movie_generics");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("date");

                entity.Property(e => e.MovieGenerics1)
                    .HasColumnName("movie_generics")
                    .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<MovieList>(entity =>
            {
                entity.ToTable("movie_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActorName)
                    .HasColumnName("actor_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ActresName)
                    .HasColumnName("actres_name")
                    .HasMaxLength(50);

                entity.Property(e => e.GenricType)
                    .HasColumnName("genric_type")
                    .HasMaxLength(50);

                entity.Property(e => e.MovieName).HasColumnName("movie_name");

                entity.Property(e => e.ReleasedDate)
                    .HasColumnName("released_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.GenricTypeNavigation)
                    .WithMany(p => p.MovieList)
                    .HasForeignKey(d => d.GenricType)
                    .HasConstraintName("FK_movie_list_movie_generics1");
            });

            modelBuilder.Entity<UserIntrestedGenerics>(entity =>
            {
                entity.ToTable("user_intrested_generics");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("date");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(50);

                entity.Property(e => e.UserIntrestId)
                    .IsRequired()
                    .HasColumnName("user_intrest_id")
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserIntrest)
                    .WithMany(p => p.UserIntrestedGenerics)
                    .HasForeignKey(d => d.UserIntrestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_intrested_generics_users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.IsVerified).HasColumnName("isVerified");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);
            });
        }
    }
}
