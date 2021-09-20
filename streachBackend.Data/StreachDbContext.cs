using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using streachBackend.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace streachBackend.Data
{
   public class StreachDbContext : IdentityDbContext
    {
        public StreachDbContext() { }
        public StreachDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<WebPosts> WebPosts { get; set; }
    }
}
