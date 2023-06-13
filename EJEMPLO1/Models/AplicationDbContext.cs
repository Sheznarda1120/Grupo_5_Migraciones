using Entidades_Proyecto_GP5.Models;
using Microsoft.EntityFrameworkCore;

namespace EJEMPLO1.model
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Vendedor> vendedor {get; set;}
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<venta_encabezado> venta_Encabezado { get; set; }
        public DbSet<Venta_detalle> venta_detalle { get; set; }
        public DbSet<Proveedor> proveedor { get; set; }
        public DbSet<Compra_encabezado> compra_encabezado { get; set; }        
        public DbSet<Compra_detalle> compra_detalle { get; set; }


        


    }
}