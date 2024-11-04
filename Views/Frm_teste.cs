using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgenda.Controler
{
    public partial class Frm_teste : Form
    {
        public Frm_teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           UsuarioController usuarioController = new UsuarioController();
            bool resultado = usuarioController.LogarUsuario("godo", "AlexLindao");
            MessageBox.Show(resultado.ToString());
            
        }
    }
}
