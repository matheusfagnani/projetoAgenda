using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAgenda
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void habilitarbotãodecadastro()
        {
            if (campo_nome.Text != "" && campo_usuario.Text.Length >= 8 && campo_senha.Text.Length >= 8 && campo_repita.Text == campo_senha.Text)
            {
                btn_cadastro.Enabled = true;

            }
            else
            {
                btn_cadastro.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarbotãodecadastro();

        }

        private void campo_usuario_TextChanged(object sender, EventArgs e)
        {
            habilitarbotãodecadastro();
        }

        private void btn_senha_TextChanged(object sender, EventArgs e)
        {
            habilitarbotãodecadastro();
        }

        private void campo_repita_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

