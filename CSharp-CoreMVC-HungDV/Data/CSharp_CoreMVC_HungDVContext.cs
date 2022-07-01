using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSharp_CoreMVC_HungDV.Models;

namespace CSharp_CoreMVC_HungDV.Data
{
    public class CSharp_CoreMVC_HungDVContext : DbContext
    {
        public CSharp_CoreMVC_HungDVContext (DbContextOptions<CSharp_CoreMVC_HungDVContext> options)
            : base(options)
        {
        }

        public DbSet<CSharp_CoreMVC_HungDV.Models.Movie> Movie { get; set; }
    }
}
