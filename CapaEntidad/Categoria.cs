using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Categoria
    {
        public int IdCategoia { get; set; }
        public string Descripcion { get; set; }
        public string NombreCompleto { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
