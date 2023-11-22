
using API_Productos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Productos.DbContext
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Console.WriteLine("Opciones de contexto: " + options.ToString());
        }

        // Tus DbSets aquí
        public DbSet<TypeDocuments> TypeDocuments { get; set; }
        public DbSet<TypeCustomers> TypeCustomers { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<ItemsBills> ItemsBills { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProdImages> ProdImages { get; set; }
    }
}
