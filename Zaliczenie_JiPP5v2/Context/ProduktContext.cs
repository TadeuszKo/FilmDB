using Zaliczenie_JiPP5v2.Models;
using Microsoft.EntityFrameworkCore;

namespace Zaliczenie_JiPP5v2.Context

{
    public class ProduktContext :DbContext
    {
        public DbSet<ProduktModel> Produkty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProduktDBv2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(cs);
        }
    }
}
