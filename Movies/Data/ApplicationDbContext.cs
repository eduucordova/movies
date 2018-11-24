using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.HasDefaultSchema("MoviesApp");

            MapMovie(modelBuilder);
            MapCastMember(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }

        private void MapMovie(ModelBuilder movie)
        {
            movie.Entity<Movie>(etd =>
            {
                etd.ToTable("tblMovies");
                etd.HasKey(c => c.MovieId).HasName("MovieId");
                etd.Property(c => c.MovieId).HasColumnName("MovieId").ValueGeneratedOnAdd();
                etd.Property(c => c.Title).HasColumnName("Title");
                etd.Property(c => c.Director).HasColumnName("DirectorName");
                etd.Property(c => c.Duration).HasColumnName("Duration");
                etd.Property(c => c.ReleaseDate).HasColumnName("ReleaseDate");
                etd.Property(c => c.Thumbnail).HasColumnName("Thumbnail");
            });
        }

        private void MapCastMember(ModelBuilder castMember)
        {
            castMember.Entity<CastMember>(etd =>
            {
                etd.ToTable("tblCastMembers");
                etd.HasKey(p => p.CastMemberId).HasName("CastMemberId");
                etd.Property(c => c.CastMemberId).HasColumnName("CastMemberId").ValueGeneratedOnAdd();
                etd.Property(c => c.ActorName).HasColumnName("ActorName");
                etd.Property(c => c.CharacterName).HasColumnName("CharacterName");
            });
        }
    }
}
