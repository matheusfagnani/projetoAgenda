namespace projetoAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void habilitarbot�odelogin()
        {
            if (textBox1.Text != "" && textBox2.Text.Length >= 8)
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
            habilitarbot�odelogin();
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            habilitarbot�odelogin();
        }
    }
     }

