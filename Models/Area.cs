using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfumeria.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
