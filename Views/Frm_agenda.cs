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
    public partial class Frm_agenda : Form
    {
        public Frm_agenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {

            ContatoController contato = new ContatoController();
            bool resultado = contato.AddContato(campo_contato.Text, campo_numero.Text, Campo_categoria.Text);
            if (resultado == true)
            {
                MessageBox.Show("cadastro concluido");

            }
            else
            {
                MessageBox.Show("erro ao cadastrar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}


