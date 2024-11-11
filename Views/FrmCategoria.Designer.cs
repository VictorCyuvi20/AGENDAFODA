namespace AGENDAFODA.Views
{
    partial class FrmCategoria
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
            BTT_CADASTRAR_CATE = new Button();
            CATEGORIA = new TextBox();
            TABELA_CONTATOS = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TABELA_CONTATOS).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTT_CADASTRAR_CATE);
            groupBox1.Controls.Add(CATEGORIA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CATEGORIA";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BTT_CADASTRAR_CATE
            // 
            BTT_CADASTRAR_CATE.Location = new Point(6, 67);
            BTT_CADASTRAR_CATE.Name = "BTT_CADASTRAR_CATE";
            BTT_CADASTRAR_CATE.Size = new Size(308, 50);
            BTT_CADASTRAR_CATE.TabIndex = 1;
            BTT_CADASTRAR_CATE.Text = "CADASTRAR";
            BTT_CADASTRAR_CATE.UseVisualStyleBackColor = true;
            BTT_CADASTRAR_CATE.Click += BTT_CADASTRAR_CATE_Click;
            // 
            // CATEGORIA
            // 
            CATEGORIA.Location = new Point(6, 22);
            CATEGORIA.Name = "CATEGORIA";
            CATEGORIA.Size = new Size(308, 23);
            CATEGORIA.TabIndex = 1;
            // 
            // TABELA_CONTATOS
            // 
            TABELA_CONTATOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABELA_CONTATOS.Location = new Point(348, 12);
            TABELA_CONTATOS.Name = "TABELA_CONTATOS";
            TABELA_CONTATOS.Size = new Size(463, 127);
            TABELA_CONTATOS.TabIndex = 1;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 151);
            Controls.Add(TABELA_CONTATOS);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TABELA_CONTATOS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BTT_CADASTRAR_CATE;
        private TextBox CATEGORIA;
        private DataGridView TABELA_CONTATOS;
    }
}