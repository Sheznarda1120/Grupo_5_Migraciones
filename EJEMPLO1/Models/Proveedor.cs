using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class Proveedor
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo_electronico { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }
    }
}
