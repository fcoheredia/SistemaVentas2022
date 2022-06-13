using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string Documento { get; set; }
        public Usuaros oIdUsuario { get; set; }
        public Proveedor oIdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<Detalle_Compra> oDetalle_Compra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
