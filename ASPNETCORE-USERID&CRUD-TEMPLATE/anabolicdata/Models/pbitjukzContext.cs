using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace anabolicdata.Models
{
    public partial class pbitjukzContext : DbContext
    {
        public pbitjukzContext()
        {
        }

        public pbitjukzContext(DbContextOptions<pbitjukzContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PgStatStatements> PgStatStatements { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Server=lallah.db.elephantsql.com;Database=pbitjukz;Port=5432;User Id=pbitjukz;Password=PASSWORD;Ssl Mode=Require;Trust Server Certificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("btree_gin")
                .HasPostgresExtension("btree_gist")
                .HasPostgresExtension("citext")
                .HasPostgresExtension("cube")
                .HasPostgresExtension("dblink")
                .HasPostgresExtension("dict_int")
                .HasPostgresExtension("dict_xsyn")
                .HasPostgresExtension("earthdistance")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("hstore")
                .HasPostgresExtension("intarray")
                .HasPostgresExtension("ltree")
                .HasPostgresExtension("pg_stat_statements")
                .HasPostgresExtension("pg_trgm")
                .HasPostgresExtension("pgcrypto")
                .HasPostgresExtension("pgrowlocks")
                .HasPostgresExtension("pgstattuple")
                .HasPostgresExtension("tablefunc")
                .HasPostgresExtension("unaccent")
                .HasPostgresExtension("uuid-ossp")
                .HasPostgresExtension("xml2");

            modelBuilder.Entity<PgStatStatements>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pg_stat_statements");

                entity.Property(e => e.BlkReadTime).HasColumnName("blk_read_time");

                entity.Property(e => e.BlkWriteTime).HasColumnName("blk_write_time");

                entity.Property(e => e.Calls).HasColumnName("calls");

                entity.Property(e => e.Dbid)
                    .HasColumnName("dbid")
                    .HasColumnType("oid");

                entity.Property(e => e.LocalBlksDirtied).HasColumnName("local_blks_dirtied");

                entity.Property(e => e.LocalBlksHit).HasColumnName("local_blks_hit");

                entity.Property(e => e.LocalBlksRead).HasColumnName("local_blks_read");

                entity.Property(e => e.LocalBlksWritten).HasColumnName("local_blks_written");

                entity.Property(e => e.MaxTime).HasColumnName("max_time");

                entity.Property(e => e.MeanTime).HasColumnName("mean_time");

                entity.Property(e => e.MinTime).HasColumnName("min_time");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.Queryid).HasColumnName("queryid");

                entity.Property(e => e.Rows).HasColumnName("rows");

                entity.Property(e => e.SharedBlksDirtied).HasColumnName("shared_blks_dirtied");

                entity.Property(e => e.SharedBlksHit).HasColumnName("shared_blks_hit");

                entity.Property(e => e.SharedBlksRead).HasColumnName("shared_blks_read");

                entity.Property(e => e.SharedBlksWritten).HasColumnName("shared_blks_written");

                entity.Property(e => e.StddevTime).HasColumnName("stddev_time");

                entity.Property(e => e.TempBlksRead).HasColumnName("temp_blks_read");

                entity.Property(e => e.TempBlksWritten).HasColumnName("temp_blks_written");

                entity.Property(e => e.TotalTime).HasColumnName("total_time");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("oid");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("Reports_pkey");

                entity.Property(e => e.ReportId).HasColumnName("report_id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Bloodwork)
                    .HasColumnName("bloodwork")
                    .HasColumnType("character varying");

                entity.Property(e => e.Compound)
                    .HasColumnName("compound")
                    .HasColumnType("character varying");

                entity.Property(e => e.Conditions)
                    .HasColumnName("conditions")
                    .HasColumnType("character varying");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasColumnType("character varying");

                entity.Property(e => e.SideEffects)
                    .HasColumnName("sideEffects")
                    .HasColumnType("character varying");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
