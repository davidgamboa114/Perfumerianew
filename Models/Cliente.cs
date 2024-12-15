using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int? ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int? MetodoDePagoId { get; set; }
        public MetodoDePago MetodoDePago { get; set; }
        public int? AreaId { get; set; }
        public Area Area { get; set; }



        public override string ToString()
        {
            return Nombre;
        }
    }

}
