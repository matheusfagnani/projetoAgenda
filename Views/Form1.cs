using projetoAgenda.Views;
using ProjetoAgenda.Controller;

namespace projetoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void habilitarbotãodelogin()
        {
            if (txt_usuario.Text != "" && txt_senha.Text.Length >= 8)
            {
                btn_logar.Enabled = true;

            }
            else
                btn_logar.Enabled = false;
        }


        private void cadastrar_Click(object sender, EventArgs e)
        {
            cadastro janela_cadastro = new cadastro();
            janela_cadastro.ShowDialog();

        }
        // para abilitar o botao de login \\
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            habilitarbotãodelogin();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            habilitarbotãodelogin();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            bool resultado = usuarioController.LogarUsuario(txt_usuario.Text, txt_senha.Text);
           

            this.Hide();
            
            Frm_tela_principal frm_Tela_Principal = new Frm_tela_principal();
            frm_Tela_Principal.ShowDialog();
        }
    }
}

