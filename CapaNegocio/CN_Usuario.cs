using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        //debuelbe el metodo listar de la capa usuario
        private CD_Usuaio objcd_Usuario = new CD_Usuaio();
        
        public List<Usuaros> listar()
        {
            return objcd_Usuario.listar();
        }
    }
}
