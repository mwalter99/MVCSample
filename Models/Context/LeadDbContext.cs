using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using MVCSample.Models;

namespace MVCSample.Models.Context
{
    public class LeadDbContext : DbContext
    {
        public LeadDbContext() : base("LeadDbContext")
        {
        }

        public DbSet<Lead> Leads { get; set; }
    }
}