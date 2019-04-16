using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vulnerabilities.Data.Models;

namespace Vulnerabilities.Data.Context
{
    public class MDCMissingPatchDbContext : DbContext
    {
        public virtual DbSet<Server> Servers { get; set; }

        public virtual DbSet<Vulnerability> Vulnerabilities { get; set; }

        public MDCMissingPatchDbContext(DbContextOptions<MDCMissingPatchDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ServerVulnerability>()
                .HasKey(sv => new { sv.ServerId, sv.VulnerabilityId });

            builder.Entity<ServerVulnerability>()
                .HasOne(sv => sv.Server)
                .WithMany(s => s.Vulnerabilities)
                .HasForeignKey(sv => sv.ServerId);

            builder.Entity<ServerVulnerability>()
                .HasOne(sv => sv.Vulnerability)
                .WithMany(v => v.Servers)
                .HasForeignKey(sv => sv.VulnerabilityId);
        }
    }
}
