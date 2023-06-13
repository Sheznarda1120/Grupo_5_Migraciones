using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class Compra_encabezado
    {
        public int id { get; set; }
        [Required]
        public int total { get; set; }
        public DateTime fecha_registro { get; set;}
        public Boolean estado { get; set; }

        public int proveedorid { get; set; }

        public Proveedor Proveedor { get; set; }
    }
}
