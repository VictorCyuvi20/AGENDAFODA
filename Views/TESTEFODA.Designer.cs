namespace AGENDAFODA.Views
{
    partial class TESTEFODA
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
            BTT_GUARDA = new Button();
            BTT_MOSTRA = new Button();
            TXT_NOME = new TextBox();
            TXT_SENHA = new TextBox();
            TXT_USU = new TextBox();
            SuspendLayout();
            // 
            // BTT_GUARDA
            // 
            BTT_GUARDA.Location = new Point(12, 63);
            BTT_GUARDA.Name = "BTT_GUARDA";
            BTT_GUARDA.Size = new Size(688, 117);
            BTT_GUARDA.TabIndex = 0;
            BTT_GUARDA.Text = "button1";
            BTT_GUARDA.UseVisualStyleBackColor = true;
            BTT_GUARDA.Click += BTT_GUARDA_Click;
            // 
            // BTT_MOSTRA
            // 
            BTT_MOSTRA.Location = new Point(12, 215);
            BTT_MOSTRA.Name = "BTT_MOSTRA";
            BTT_MOSTRA.Size = new Size(688, 117);
            BTT_MOSTRA.TabIndex = 1;
            BTT_MOSTRA.Text = "button2";
            BTT_MOSTRA.UseVisualStyleBackColor = true;
            BTT_MOSTRA.Click += BTT_MOSTRA_Click;
            // 
            // TXT_NOME
            // 
            TXT_NOME.Location = new Point(12, 22);
            TXT_NOME.Name = "TXT_NOME";
            TXT_NOME.Size = new Size(162, 23);
            TXT_NOME.TabIndex = 2;
            // 
            // TXT_SENHA
            // 
            TXT_SENHA.Location = new Point(456, 22);
            TXT_SENHA.Name = "TXT_SENHA";
            TXT_SENHA.Size = new Size(244, 23);
            TXT_SENHA.TabIndex = 3;
            // 
            // TXT_USU
            // 
            TXT_USU.Location = new Point(192, 22);
            TXT_USU.Name = "TXT_USU";
            TXT_USU.Size = new Size(244, 23);
            TXT_USU.TabIndex = 4;
            // 
            // TESTEFODA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TXT_USU);
            Controls.Add(TXT_SENHA);
            Controls.Add(TXT_NOME);
            Controls.Add(BTT_MOSTRA);
            Controls.Add(BTT_GUARDA);
            Name = "TESTEFODA";
            Text = "TESTEFODA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTT_GUARDA;
        private Button BTT_MOSTRA;
        private TextBox TXT_NOME;
        private TextBox TXT_SENHA;
        private TextBox TXT_USU;
    }
}