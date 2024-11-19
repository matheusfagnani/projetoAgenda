namespace projetoAgenda.Views
{
    partial class Frm_categorias
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
            txtCategoria = new TextBox();
            button2 = new Button();
            dgvCategorias = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btn_excluir = new Button();
            alterar_senha = new GroupBox();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            groupBox1.SuspendLayout();
            alterar_senha.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 22);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(226, 23);
            txtCategoria.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(9, 74);
            button2.Name = "button2";
            button2.Size = new Size(169, 36);
            button2.TabIndex = 1;
            button2.Text = "registrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(279, 52);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(356, 104);
            dgvCategorias.TabIndex = 2;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(364, 14);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 3;
            button1.Text = "atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.maxresdefault;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(btn_excluir);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvCategorias);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(2, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(889, 310);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "categoria";
            // 
            // btn_excluir
            // 
            btn_excluir.ForeColor = SystemColors.ActiveCaptionText;
            btn_excluir.Location = new Point(341, 162);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(169, 36);
            btn_excluir.TabIndex = 4;
            btn_excluir.Text = "excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += button4_Click;
            // 
            // alterar_senha
            // 
            alterar_senha.BackColor = Color.Transparent;
            alterar_senha.Controls.Add(button3);
            alterar_senha.Controls.Add(textBox1);
            alterar_senha.ForeColor = SystemColors.ActiveCaptionText;
            alterar_senha.Location = new Point(927, 22);
            alterar_senha.Name = "alterar_senha";
            alterar_senha.Size = new Size(252, 101);
            alterar_senha.TabIndex = 4;
            alterar_senha.TabStop = false;
            alterar_senha.Text = "Alterar Senha";
            // 
            // button3
            // 
            button3.Location = new Point(6, 59);
            button3.Name = "button3";
            button3.Size = new Size(216, 23);
            button3.TabIndex = 1;
            button3.Text = "alterar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 0;
            // 
            // Frm_categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 311);
            Controls.Add(alterar_senha);
            Controls.Add(groupBox1);
            Name = "Frm_categorias";
            Text = "Frm_categorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            alterar_senha.ResumeLayout(false);
            alterar_senha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCategoria;
        private Button button2;
        private DataGridView dgvCategorias;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox alterar_senha;
        private TextBox textBox1;
        private Button button3;
        private Button btn_excluir;
    }
}