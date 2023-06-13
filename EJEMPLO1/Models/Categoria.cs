using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Required]
        public string nombre_categoria { get; set; }
        public DateTime fecha_registro { get; set; }
        public Boolean estado { get; set; }
    }
}
