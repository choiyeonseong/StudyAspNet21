using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortpolioWeb.Models;

namespace PortpolioWeb.Data
{
    public class PortpolioWebContext : IdentityDbContext
    {
        public PortpolioWebContext (DbContextOptions<PortpolioWebContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Account { get; set; }

        public DbSet<Board> Board { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Manage> Manage { get; set; }
    }
}
