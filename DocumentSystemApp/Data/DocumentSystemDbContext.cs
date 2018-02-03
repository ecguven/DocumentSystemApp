﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DocumentSystemApp.Models;
using DocumentSystemApp.Data.Entities;

namespace DocumentSystemApp.Data
{
    public class DocumentSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public DocumentSystemDbContext(DbContextOptions<DocumentSystemDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ChangeRequestForm> ChangeRequestForms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<ChangeRequestForm>().ToTable("ChangeRequestForms");
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
