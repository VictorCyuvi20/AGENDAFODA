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
            BTT_EXClUIR = new Button();
            BTT_CADASTRAR_CATE = new Button();
            CATEGORIA = new TextBox();
            TABELA_CONTATOS = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TABELA_CONTATOS).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BTT_EXClUIR);
            groupBox1.Controls.Add(BTT_CADASTRAR_CATE);
            groupBox1.Controls.Add(CATEGORIA);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CATEGORIA";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // BTT_EXClUIR
            // 
            BTT_EXClUIR.BackColor = Color.IndianRed;
            BTT_EXClUIR.Location = new Point(6, 121);
            BTT_EXClUIR.Name = "BTT_EXClUIR";
            BTT_EXClUIR.Size = new Size(308, 50);
            BTT_EXClUIR.TabIndex = 2;
            BTT_EXClUIR.Text = "EXCLUIR";
            BTT_EXClUIR.UseVisualStyleBackColor = false;
            BTT_EXClUIR.Click += BTT_EXClUIR_Click;
            // 
            // BTT_CADASTRAR_CATE
            // 
            BTT_CADASTRAR_CATE.Location = new Point(6, 65);
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
            TABELA_CONTATOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TABELA_CONTATOS.Size = new Size(463, 177);
            TABELA_CONTATOS.TabIndex = 1;
            TABELA_CONTATOS.CellContentClick += TABELA_CONTATOS_CellContentClick;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 201);
            Controls.Add(TABELA_CONTATOS);
            Controls.Add(groupBox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
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
        private Button BTT_EXClUIR;
    }
}