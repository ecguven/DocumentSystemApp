﻿// <auto-generated />
using DocumentSystemApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DocumentSystemApp.Data.Migrations
{
    [DbContext(typeof(DocumentSystemDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentSystemApp.Data.Entities.ChangeRequestForm", b =>
                {
                    b.Property<int>("ChangeRequestFormId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attachments");

                    b.Property<string>("CHAPrintName1");

                    b.Property<string>("CHAPrintName2");

                    b.Property<string>("CHAPrintName3");

                    b.Property<string>("CHARole1");

                    b.Property<string>("CHARole2");

                    b.Property<string>("CHARole3");

                    b.Property<string>("CHASignatureDate1");

                    b.Property<string>("CHASignatureDate2");

                    b.Property<string>("CHASignatureDate3");

                    b.Property<bool>("ChangeAccept");

                    b.Property<string>("ChangeJustification");

                    b.Property<string>("ChangeReason");

                    b.Property<bool>("ChangeReject");

                    b.Property<string>("ChangeRequestDescrpition");

                    b.Property<string>("ChangeRequestID");

                    b.Property<bool>("ChangeType1BugFixing");

                    b.Property<bool>("ChangeType1DesignChange");

                    b.Property<bool>("ChangeType1NewRequirement");

                    b.Property<bool>("ChangeType1Other");

                    b.Property<bool>("ChangeType1RequirementChange");

                    b.Property<bool>("ChangeType2Commercial");

                    b.Property<bool>("ChangeType2Investment");

                    b.Property<string>("ChangeType2Text");

                    b.Property<int>("CompanyId");

                    b.Property<bool>("ConfigurationFirmware");

                    b.Property<bool>("ConfigurationHardware");

                    b.Property<bool>("ConfigurationSoftware");

                    b.Property<bool>("ConfigurationSystemDocumentation");

                    b.Property<bool>("ConfigurationUserTraining");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("CreatorUserId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FAPrintName1");

                    b.Property<string>("FAPrintName2");

                    b.Property<string>("FAPrintName3");

                    b.Property<string>("FARole1");

                    b.Property<string>("FARole2");

                    b.Property<string>("FARole3");

                    b.Property<string>("FASignatureDate1");

                    b.Property<string>("FASignatureDate2");

                    b.Property<string>("FASignatureDate3");

                    b.Property<string>("ImpactAssessmentDC");

                    b.Property<string>("ImpactAssessmentMA");

                    b.Property<string>("ImpactAssessmentOth");

                    b.Property<string>("ImpactAssessmentToA");

                    b.Property<string>("ImpactAssessmentTtE");

                    b.Property<string>("InitiatedBy");

                    b.Property<bool>("PriorityEmergency");

                    b.Property<bool>("PriorityNextVersion");

                    b.Property<bool>("PriorityRoutine");

                    b.Property<string>("ReferenceNumber");

                    b.Property<string>("SPRS");

                    b.Property<DateTime>("SignatureDate");

                    b.Property<string>("SummaryofResults");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<string>("UpdaterUserId");

                    b.Property<string>("Version");

                    b.Property<bool>("bImpactAssessmentDC");

                    b.Property<bool>("bImpactAssessmentMA");

                    b.Property<bool>("bImpactAssessmentOth");

                    b.Property<bool>("bImpactAssessmentToA");

                    b.Property<bool>("bImpactAssessmentTtE");

                    b.HasKey("ChangeRequestFormId");

                    b.ToTable("ChangeRequestForms");
                });

            modelBuilder.Entity("DocumentSystemApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DocumentSystemApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DocumentSystemApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DocumentSystemApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DocumentSystemApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
