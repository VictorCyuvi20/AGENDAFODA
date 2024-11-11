namespace AGENDAFODA
{
    partial class FRMCADASTRAR
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            INPUTNOME = new TextBox();
            INPUTUSUARIO = new TextBox();
            INPUTTELEFONE = new TextBox();
            INPUTSENHA = new TextBox();
            INPUTSENHA2 = new TextBox();
            BTTCADASTRAR = new Button();
            BTTCANCELAR = new Button();
            BRANCO = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BRANCO2 = new Label();
            VERIFICASENHA = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 164);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "TELEFONE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 81);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "USUÁRIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 238);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "SENHA ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 308);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 4;
            label5.Text = "CONFIRMAR SENHA";
            // 
            // INPUTNOME
            // 
            INPUTNOME.Location = new Point(35, 38);
            INPUTNOME.Name = "INPUTNOME";
            INPUTNOME.Size = new Size(100, 23);
            INPUTNOME.TabIndex = 5;
            INPUTNOME.TextChanged += INPUTNOME_TextChanged;
            // 
            // INPUTUSUARIO
            // 
            INPUTUSUARIO.Location = new Point(35, 118);
            INPUTUSUARIO.Name = "INPUTUSUARIO";
            INPUTUSUARIO.Size = new Size(100, 23);
            INPUTUSUARIO.TabIndex = 6;
            INPUTUSUARIO.TextChanged += INPUTUSUARIO_TextChanged;
            // 
            // INPUTTELEFONE
            // 
            INPUTTELEFONE.Location = new Point(35, 196);
            INPUTTELEFONE.Name = "INPUTTELEFONE";
            INPUTTELEFONE.Size = new Size(100, 23);
            INPUTTELEFONE.TabIndex = 7;
            // 
            // INPUTSENHA
            // 
            INPUTSENHA.Location = new Point(35, 268);
            INPUTSENHA.Name = "INPUTSENHA";
            INPUTSENHA.Size = new Size(100, 23);
            INPUTSENHA.TabIndex = 8;
            INPUTSENHA.TextChanged += INPUTSENHA_TextChanged;
            // 
            // INPUTSENHA2
            // 
            INPUTSENHA2.Location = new Point(35, 353);
            INPUTSENHA2.Name = "INPUTSENHA2";
            INPUTSENHA2.Size = new Size(100, 23);
            INPUTSENHA2.TabIndex = 9;
            // 
            // BTTCADASTRAR
            // 
            BTTCADASTRAR.Enabled = false;
            BTTCADASTRAR.Location = new Point(363, 38);
            BTTCADASTRAR.Name = "BTTCADASTRAR";
            BTTCADASTRAR.Size = new Size(112, 65);
            BTTCADASTRAR.TabIndex = 10;
            BTTCADASTRAR.Text = "CADASTRAR";
            BTTCADASTRAR.UseVisualStyleBackColor = true;
            BTTCADASTRAR.Click += BTTCADASTRAR_Click;
            // 
            // BTTCANCELAR
            // 
            BTTCANCELAR.Location = new Point(363, 308);
            BTTCANCELAR.Name = "BTTCANCELAR";
            BTTCANCELAR.Size = new Size(112, 65);
            BTTCANCELAR.TabIndex = 11;
            BTTCANCELAR.Text = "CANCELAR";
            BTTCANCELAR.UseVisualStyleBackColor = true;
            BTTCANCELAR.Click += BTTCANCELAR_Click;
            // 
            // BRANCO
            // 
            BRANCO.AutoSize = true;
            BRANCO.Location = new Point(83, 20);
            BRANCO.Name = "BRANCO";
            BRANCO.Size = new Size(225, 15);
            BRANCO.TabIndex = 12;
            BRANCO.Text = "!ESTE CAMPO NÃO PODE FICAR VAZIO✖";
            // 
            // BRANCO2
            // 
            BRANCO2.AutoSize = true;
            BRANCO2.Location = new Point(83, 100);
            BRANCO2.Name = "BRANCO2";
            BRANCO2.Size = new Size(225, 15);
            BRANCO2.TabIndex = 13;
            BRANCO2.Text = "!ESTE CAMPO NÃO PODE FICAR VAZIO✖";
            // 
            // VERIFICASENHA
            // 
            VERIFICASENHA.AutoSize = true;
            VERIFICASENHA.Location = new Point(83, 335);
            VERIFICASENHA.Name = "VERIFICASENHA";
            VERIFICASENHA.Size = new Size(165, 15);
            VERIFICASENHA.TabIndex = 14;
            VERIFICASENHA.Text = "AS SENHAS NÃO SÃO IGUAIS!";
            // 
            // FRMCADASTRAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(VERIFICASENHA);
            Controls.Add(BRANCO2);
            Controls.Add(BRANCO);
            Controls.Add(BTTCANCELAR);
            Controls.Add(BTTCADASTRAR);
            Controls.Add(INPUTSENHA2);
            Controls.Add(INPUTSENHA);
            Controls.Add(INPUTTELEFONE);
            Controls.Add(INPUTUSUARIO);
            Controls.Add(INPUTNOME);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMCADASTRAR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRMCADASTRAR";
            Load += FRMCADASTRAR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox INPUTNOME;
        private TextBox INPUTUSUARIO;
        private TextBox INPUTTELEFONE;
        private TextBox INPUTSENHA;
        private TextBox INPUTSENHA2;
        private Button BTTCADASTRAR;
        private Button BTTCANCELAR;
        private Label BRANCO;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label BRANCO2;
        private Label VERIFICASENHA;
    }
}