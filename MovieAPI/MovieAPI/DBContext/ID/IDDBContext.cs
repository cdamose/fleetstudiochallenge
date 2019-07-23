using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieAPI.DBContext
{
    public partial class IDDBContext : DbContext
    {
        public IDDBContext()
        {
        }

        public IDDBContext(DbContextOptions<IDDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<UsersToken> UsersToken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=id_db;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientSecrect)
                    .IsRequired()
                    .HasColumnName("client_secrect")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<UsersToken>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("users_token");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasColumnName("access_token")
                    .HasMaxLength(500);

                entity.Property(e => e.AccessTokenLifeTime)
                    .HasColumnName("access_token_life_time")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AcessTokenCreatedDate)
                    .HasColumnName("acess_token_created_date")
                    .HasColumnType("date");

                entity.Property(e => e.RefreshToken)
                    .IsRequired()
                    .HasColumnName("refresh_token")
                    .HasMaxLength(500);

                entity.Property(e => e.RefreshTokenCretaedDate)
                    .HasColumnName("refresh_token_cretaed_date")
                    .HasColumnType("date");

                entity.Property(e => e.RefreshTokenLifeTime)
                    .HasColumnName("refresh_token_life_time")
                    .HasColumnType("numeric(18, 0)");
            });
        }
    }
}
