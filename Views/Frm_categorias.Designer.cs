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
            groupBox1 = new GroupBox();
            button1 = new Button();
            dgvCategorias = new DataGridView();
            button2 = new Button();
            txtCategoria = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.maxresdefault;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvCategorias);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Location = new Point(3, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "categoria";
            // 
            // button1
            // 
            button1.Location = new Point(364, 14);
            button1.Name = "button1";
            button1.Size = new Size(169, 36);
            button1.TabIndex = 3;
            button1.Text = "atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(279, 52);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(356, 104);
            dgvCategorias.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(9, 74);
            button2.Name = "button2";
            button2.Size = new Size(169, 36);
            button2.TabIndex = 1;
            button2.Text = "registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 22);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(226, 23);
            txtCategoria.TabIndex = 1;
            // 
            // Frm_categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 286);
            Controls.Add(groupBox1);
            Name = "Frm_categorias";
            Text = "Frm_categorias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox txtCategoria;
        private DataGridView dgvCategorias;
        private Button button1;
    }
}