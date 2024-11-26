namespace projetoAgenda.Views
{
    partial class Frm_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_agenda));
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            cadastrar = new Button();
            CampoCategoria = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            campo_contato = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(cadastrar);
            groupBox1.Controls.Add(CampoCategoria);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(campo_contato);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(131, 282);
            button3.Name = "button3";
            button3.Size = new Size(83, 43);
            button3.TabIndex = 10;
            button3.Text = "excluir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(13, 346);
            button2.Name = "button2";
            button2.Size = new Size(83, 43);
            button2.TabIndex = 9;
            button2.Text = "alterar";
            button2.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(13, 282);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(83, 43);
            cadastrar.TabIndex = 8;
            cadastrar.Text = "cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            // 
            // CampoCategoria
            // 
            CampoCategoria.Location = new Point(0, 241);
            CampoCategoria.Name = "CampoCategoria";
            CampoCategoria.Size = new Size(243, 23);
            CampoCategoria.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(0, 197);
            label3.Name = "label3";
            label3.Size = new Size(119, 32);
            label3.TabIndex = 6;
            label3.Text = "categoria ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(0, 114);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 5;
            label2.Text = "telefone ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 32);
            label1.TabIndex = 3;
            label1.Text = "contato";
            label1.Click += label1_Click;
            // 
            // campo_contato
            // 
            campo_contato.Location = new Point(0, 64);
            campo_contato.Name = "campo_contato";
            campo_contato.Size = new Size(243, 23);
            campo_contato.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(316, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(491, 245);
            dataGridView1.TabIndex = 11;
            // 
            // Frm_agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1485, 546);
            Controls.Add(groupBox1);
            Name = "Frm_agenda";
            Text = "Frm_agenda";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox campo_contato;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button cadastrar;
        private TextBox CampoCategoria;
        private Label label3;
        private DataGridView dataGridView1;
    }
}