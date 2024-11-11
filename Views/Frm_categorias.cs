using projetoAgenda.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgenda.Views
{
    public partial class Frm_categorias : Form
    {
        public Frm_categorias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoriaController categoria = new categoriaController();
            bool resultado = categoria.AddCategoria(txtCategoria.Text);
            if (resultado == true)
            {
                MessageBox.Show("cadastro concluido");

            }
            else
            {
                MessageBox.Show("erro ao cadastrar");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriaController controleCategoria  = new categoriaController();

          
         DataTable tabela = controleCategoria.GetCategoria();
            dgvCategorias.DataSource = tabela; 
            

        }
    }
}
