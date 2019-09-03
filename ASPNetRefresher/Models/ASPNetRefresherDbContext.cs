namespace ASPNetRefresher.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ASPNetRefresherDbContext : DbContext
    {
        public ASPNetRefresherDbContext()
            : base("name=DefaultConnection")
        { 
        }

        public virtual DbSet<Titanite> Titanites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Titanite>()
                .Property(e => e.citation)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.sample_name)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.tectonic_setting)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.location_comment)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.latitude_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.latitude_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.longitude_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.longitude_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.land_sea_sampling)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.elevation_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.elevation_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rock_name)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rock_texture)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.drilling_depth_min)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.drilling_depth_max)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.alteration)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.mineral)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.spot)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.crystal)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.rim_core_mineral_grains)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.grain_size)
                .IsUnicode(false);

            modelBuilder.Entity<Titanite>()
                .Property(e => e.primary_secondary)
                .IsUnicode(false);
        }
    }
}
