using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades_Proyecto_GP5.Models
{
    public class Genero
    {
        public int id { get; set; }
        [Required]
        public string nombre_genero { get; set;}
        public DateTime fecha_registro { get; set;}
        public Boolean estado { get; set; }
    }
}
