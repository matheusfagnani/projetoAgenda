namespace projetoAgenda
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            campo_nome = new TextBox();
            usuario = new Label();
            campo_usuario = new TextBox();
            campo_telefone = new TextBox();
            telefone = new Label();
            label2 = new Label();
            campo_senha = new TextBox();
            label3 = new Label();
            campo_repita = new TextBox();
            btn_cadastro = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // campo_nome
            // 
            campo_nome.Location = new Point(2, 96);
            campo_nome.Name = "campo_nome";
            campo_nome.Size = new Size(365, 23);
            campo_nome.TabIndex = 1;
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.BackColor = Color.Transparent;
            usuario.Font = new Font("Segoe UI", 15F);
            usuario.Location = new Point(2, 122);
            usuario.Name = "usuario";
            usuario.Size = new Size(76, 28);
            usuario.TabIndex = 2;
            usuario.Text = "usuario";
            // 
            // campo_usuario
            // 
            campo_usuario.Location = new Point(2, 153);
            campo_usuario.Name = "campo_usuario";
            campo_usuario.Size = new Size(365, 23);
            campo_usuario.TabIndex = 3;
            campo_usuario.TextChanged += campo_usuario_TextChanged;
            // 
            // campo_telefone
            // 
            campo_telefone.Location = new Point(2, 216);
            campo_telefone.Name = "campo_telefone";
            campo_telefone.Size = new Size(365, 23);
            campo_telefone.TabIndex = 4;
            // 
            // telefone
            // 
            telefone.AutoSize = true;
            telefone.BackColor = Color.Transparent;
            telefone.Font = new Font("Segoe UI", 15F);
            telefone.Location = new Point(2, 185);
            telefone.Name = "telefone";
            telefone.Size = new Size(83, 28);
            telefone.TabIndex = 5;
            telefone.Text = "telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 298);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 6;
            label2.Text = "senha";
            // 
            // campo_senha
            // 
            campo_senha.Location = new Point(2, 329);
            campo_senha.Name = "campo_senha";
            campo_senha.Size = new Size(173, 23);
            campo_senha.TabIndex = 7;
            campo_senha.TextChanged += btn_senha_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(2, 365);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 8;
            label3.Text = "repita a senha ";
            // 
            // campo_repita
            // 
            campo_repita.Location = new Point(2, 396);
            campo_repita.Name = "campo_repita";
            campo_repita.Size = new Size(173, 23);
            campo_repita.TabIndex = 9;
            campo_repita.TextChanged += campo_repita_TextChanged;
            // 
            // btn_cadastro
            // 
            btn_cadastro.BackColor = Color.FromArgb(255, 128, 0);
            btn_cadastro.Location = new Point(2, 452);
            btn_cadastro.Name = "btn_cadastro";
            btn_cadastro.Size = new Size(173, 31);
            btn_cadastro.TabIndex = 10;
            btn_cadastro.Text = "cadastrar";
            btn_cadastro.UseVisualStyleBackColor = false;
            btn_cadastro.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(194, 452);
            button2.Name = "button2";
            button2.Size = new Size(173, 31);
            button2.TabIndex = 11;
            button2.Text = "voltar";
            button2.UseVisualStyleBackColor = false;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(922, 594);
            Controls.Add(button2);
            Controls.Add(btn_cadastro);
            Controls.Add(campo_repita);
            Controls.Add(label3);
            Controls.Add(campo_senha);
            Controls.Add(label2);
            Controls.Add(telefone);
            Controls.Add(campo_telefone);
            Controls.Add(campo_usuario);
            Controls.Add(usuario);
            Controls.Add(campo_nome);
            Controls.Add(label1);
            Name = "cadastro";
            Text = "cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox campo_nome;
        private Label usuario;
        private TextBox campo_usuario;
        private TextBox campo_telefone;
        private Label telefone;
        private Label label2;
        private TextBox campo_senha;
        private Label label3;
        private TextBox campo_repita;
        private Button btn_cadastro;
        private Button button2;
    }
}