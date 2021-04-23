using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortpolioWeb.Models;

namespace PortpolioWeb.Data
{
    public class PortpolioWebContext : DbContext
    {
        public PortpolioWebContext (DbContextOptions<PortpolioWebContext> options)
            : base(options)
        {
        }

        public DbSet<PortpolioWeb.Models.Account> Account { get; set; }

        public DbSet<PortpolioWeb.Models.Board> Board { get; set; }

        public DbSet<PortpolioWeb.Models.Contact> Contact { get; set; }

        public DbSet<PortpolioWeb.Models.Manage> Manage { get; set; }
    }
}
