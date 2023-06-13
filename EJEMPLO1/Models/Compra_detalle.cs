using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class Compra_detalle
    {
        public int id { get; set; }
        [Required]
        public int cantidad { get; set; }
        public double precio { get; set; }

        public int compra_encabezadoid { get; set; }
        public Compra_encabezado Compra_Encabezado { get; set; }

        public int productoid { get; set; }
        public Producto Producto { get; set; }

    }
}
