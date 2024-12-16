using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
    public enum Categoria
    {
        EnStock,
        Pendiente,
        PorEncargue
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria CategoriaProducto { get; set; }  // Propiedad del enum

        public override string ToString()
        {
            return $"{Nombre} - {CategoriaProducto}";
        }
    }

}
