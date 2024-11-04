namespace projetoAgenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_senha = new TextBox();
            btn_logar = new Button();
            cadastrar = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(157, 111);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(250, 23);
            txt_usuario.TabIndex = 0;
            txt_usuario.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(157, 71);
            label1.Name = "label1";
            label1.Size = new Size(104, 37);
            label1.TabIndex = 1;
            label1.Text = "usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(157, 137);
            label2.Name = "label2";
            label2.Size = new Size(93, 37);
            label2.TabIndex = 2;
            label2.Text = "senha ";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(157, 177);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(268, 23);
            txt_senha.TabIndex = 3;
            txt_senha.TextChanged += textBox2_TextChanged;
            // 
            // btn_logar
            // 
            btn_logar.Enabled = false;
            btn_logar.Location = new Point(133, 218);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(146, 36);
            btn_logar.TabIndex = 4;
            btn_logar.Text = "entrar";
            btn_logar.UseVisualStyleBackColor = true;
            btn_logar.Click += btn_logar_Click;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(308, 218);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(146, 36);
            cadastrar.TabIndex = 5;
            cadastrar.Text = "cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += cadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cadastrar);
            Controls.Add(btn_logar);
            Controls.Add(txt_senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private Label label1;
        private Label label2;
        private TextBox txt_senha;
        private Button btn_logar;
        private Button cadastrar;
    }
}
