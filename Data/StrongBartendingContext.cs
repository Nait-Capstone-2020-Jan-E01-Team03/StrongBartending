using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StrongBartending.Models;

namespace StrongBartending.Data
{
    public partial class StrongBartendingContext : DbContext
    {
        public StrongBartendingContext()
        {
        }

        public StrongBartendingContext(DbContextOptions<StrongBartendingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<BarPays> BarPays { get; set; }
        public virtual DbSet<BarTypes> BarTypes { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<EventDetails> EventDetails { get; set; }
        public virtual DbSet<EventStatus> EventStatus { get; set; }
        public virtual DbSet<EventTypes> EventTypes { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<LeadStatus> LeadStatus { get; set; }
        public virtual DbSet<Leads> Leads { get; set; }
        public virtual DbSet<LineStatus> LineStatus { get; set; }
        public virtual DbSet<Linkbacks> Linkbacks { get; set; }
        public virtual DbSet<Services> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //MING
                //optionsBuilder.UseSqlServer("Server=(localdb)\\SQLEXPRESS;Database=StrongBartending; Trusted_Connection=True");

                //MARK
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StrongBartending;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<BarPays>(entity =>
            {
                entity.HasKey(e => e.BarPayKey);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BarTypes>(entity =>
            {
                entity.HasKey(e => e.BarTypeKey);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactKey)
                    .HasName("PK_Contact");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventDetails>(entity =>
            {
                entity.HasKey(e => e.LineKey)
                    .HasName("PK_LineKey");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.LeadKeyNavigation)
                    .WithMany(p => p.EventDetails)
                    .HasForeignKey(d => d.LeadKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadKey");

                entity.HasOne(d => d.LineStatNavigation)
                    .WithMany(p => p.EventDetails)
                    .HasForeignKey(d => d.LineStat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineStatus");

                entity.HasOne(d => d.ServiceKeyNavigation)
                    .WithMany(p => p.EventDetails)
                    .HasForeignKey(d => d.ServiceKey)
                    .HasConstraintName("FK_Services");
            });

            modelBuilder.Entity<EventStatus>(entity =>
            {
                entity.HasKey(e => e.EventStat);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EventTypes>(entity =>
            {
                entity.HasKey(e => e.EventTypeKey);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventKey);

                entity.Property(e => e.Gratuity).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Gst)
                    .HasColumnName("GST")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Hours).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reminder).HasColumnType("date");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.ContactKeyNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.ContactKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactKey");

                entity.HasOne(d => d.EventStatNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventStat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventStatus");

                entity.HasOne(d => d.LeadKeyNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.LeadKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EvnetLeadKey");
            });


            modelBuilder.Entity<LeadStatus>(entity =>
            {
                entity.HasKey(e => e.LeadStat)
                    .HasName("PK_LeadStat");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Leads>(entity =>
            {
                entity.HasKey(e => e.LeadKey);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.LegacyId)
                    .HasColumnName("LegacyID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Theme)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.BarPayKeyNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.BarPayKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BarPays");

                entity.HasOne(d => d.BarTypeKeyNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.BarTypeKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BarTypes");

                entity.HasOne(d => d.ContactKeyNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.ContactKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contacts");

                entity.HasOne(d => d.EventTypeKeyNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.EventTypeKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventTypeKey");

                entity.HasOne(d => d.LeadStatNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LeadStat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeadStatus");

                entity.HasOne(d => d.LinkKeyNavigation)
                    .WithMany(p => p.Leads)
                    .HasForeignKey(d => d.LinkKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Linkbacks");
            });

            modelBuilder.Entity<LineStatus>(entity =>
            {
                entity.HasKey(e => e.LineStat)
                    .HasName("PK_LineStatKey");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Linkbacks>(entity =>
            {
                entity.HasKey(e => e.LinkKey);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceKey);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasColumnName("UOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
