using Core.Configuration;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework.Context
{
    public class CareerContext : DbContext
    {
        private string connectionString = ContextRunSettings.ConnectionString ?? @"Server=(localdb)\MSSQLLocalDB;Database=CareerSetting;Trusted_Connection=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<CareerSetting> CareerSettings { get; set; }

        //public CareerContext(DbContextOptions<CareerContext> options) : base(options)
        //{
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<CareerSetting>(ConfigureCareerSetting);
        //}

        //private void ConfigureCareerSetting(EntityTypeBuilder<CareerSetting> builder)
        //{
        //    builder.ToTable("CareerSetting");

        //    builder.HasKey(ci => ci.Id);

        //    builder.Property(ci => ci.Id)
        //       .IsRequired();

        //    builder.Property(cb => cb.Name)
        //        .IsRequired()
        //        .HasMaxLength(300);

        //    builder.Property(cb => cb.Value)
        //        .IsRequired()
        //        .HasMaxLength(300);

        //    builder.Property(cb => cb.ApplicationName)
        //        .IsRequired()
        //        .HasMaxLength(300);

        //}
    }
}
