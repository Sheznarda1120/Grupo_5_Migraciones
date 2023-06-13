using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class venta_encabezado
    {
        public int id { get; set; }
        [Required]
        public double total_venta { get; set; }
        public string metodo_pago { get; set; }
        public DateTime fecha_registro { get; set; }
        public int vendedorid { get; set; }
        [Required]
        public Vendedor vendedor { get; set; }
        public int clienteid { get; set; }
        [Required]
        public Cliente cliente { get; set; }
        public Boolean estado { get; set; }
        

    }
}
