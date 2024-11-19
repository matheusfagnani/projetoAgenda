using projetoAgenda.variableGlobal;
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
            bool resultado = usuarioController.LogarUsuario("godo", "AlexLindão");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User_session._usuario = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User_session._usuario);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            User_session._nome = textBox1.Text;
            User_session._usuario = textBox2.Text;
            User_session._senha = textBox3.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(User_session._nome);
            MessageBox.Show(User_session._usuario);
            MessageBox.Show(User_session._senha );
        }
    }
}
