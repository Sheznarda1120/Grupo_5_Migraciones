﻿using System.ComponentModel.DataAnnotations;

namespace Entidades_Proyecto_GP5.Models
{
    public class Venta_detalle
    {
        public int id { get; set; }
        [Required]
        public int productoid { get; set; }
        [Required]
        public Producto producto { get; set; }
        public int ventaid { get; set; }
        [Required]
        public venta_encabezado Venta_encabezado { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double totalXproducto { get; set; }


    }
}
