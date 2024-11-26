using projetoAgenda.variableGlobal;
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
    public partial class Frm_tela_principal : Form
    {
        public Frm_tela_principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_categorias frm_Categorias = new Frm_categorias();
            frm_Categorias.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_tela_principal_Load(object sender, EventArgs e)
        {
            lbl_bemVindo.Text= $"{User_session._nome}";
        }
    }
}
