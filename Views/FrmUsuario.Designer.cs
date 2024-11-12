namespace AGENDAFODA.Views
{
    partial class FrmUsuario
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
            EXCLUIR = new Button();
            TABELA_USUARIO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TABELA_USUARIO).BeginInit();
            SuspendLayout();
            // 
            // EXCLUIR
            // 
            EXCLUIR.Location = new Point(26, 364);
            EXCLUIR.Name = "EXCLUIR";
            EXCLUIR.Size = new Size(435, 59);
            EXCLUIR.TabIndex = 1;
            EXCLUIR.Text = "Excluir";
            EXCLUIR.UseVisualStyleBackColor = true;
            EXCLUIR.Click += EXCLUIR_Click;
            // 
            // TABELA_USUARIO
            // 
            TABELA_USUARIO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TABELA_USUARIO.Location = new Point(26, 48);
            TABELA_USUARIO.Name = "TABELA_USUARIO";
            TABELA_USUARIO.Size = new Size(435, 280);
            TABELA_USUARIO.TabIndex = 2;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TABELA_USUARIO);
            Controls.Add(EXCLUIR);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)TABELA_USUARIO).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button EXCLUIR;
        private DataGridView TABELA_USUARIO;
    }
}