using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GoodLookTie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodLookTie.Data
{
    public class GoodLookTieContext : IdentityDbContext
    {
        public GoodLookTieContext(DbContextOptions<GoodLookTieContext> options)
            : base(options)
        {
        }
        public DbSet<Tie> Tie { get; set; }
    }
}
