using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaNegocio;
using CapaEntidad; 

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IBTNCanselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IBTNIngresar_Click(object sender, EventArgs e)
        {
            List<Usuaros> TEST = new CN_Usuario().listar();

            Usuaros oUsuario = new CN_Usuario().listar().Where(u => u.Documento == TXTBDocumento.Text && u.Clave == TXTBClave.Text).FirstOrDefault();


            Inicio form = new Inicio();
            
            form.Show();
            this.Hide();
            
            form.FormClosing += frm_closing;
        }
        private void frm_closing(object sender,FormClosingEventArgs e)
        {
            TXTBClave.Text = "";
            TXTBDocumento.Text = "";
            this.Show();
        }
    }
}
