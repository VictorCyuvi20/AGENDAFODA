namespace AGENDAFODA
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
            INPUTSENHA = new TextBox();
            INPUTEMAIL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTTENTRAR = new Button();
            BTTCADRATRO = new Label();
            SuspendLayout();
            // 
            // INPUTSENHA
            // 
            INPUTSENHA.Location = new Point(280, 219);
            INPUTSENHA.Name = "INPUTSENHA";
            INPUTSENHA.Size = new Size(187, 23);
            INPUTSENHA.TabIndex = 0;
            // 
            // INPUTEMAIL
            // 
            INPUTEMAIL.Location = new Point(280, 129);
            INPUTEMAIL.Name = "INPUTEMAIL";
            INPUTEMAIL.Size = new Size(187, 23);
            INPUTEMAIL.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 75);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 177);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // BTTENTRAR
            // 
            BTTENTRAR.Location = new Point(330, 262);
            BTTENTRAR.Name = "BTTENTRAR";
            BTTENTRAR.Size = new Size(88, 34);
            BTTENTRAR.TabIndex = 4;
            BTTENTRAR.Text = "ENTRAR";
            BTTENTRAR.UseVisualStyleBackColor = true;
            // 
            // BTTCADRATRO
            // 
            BTTCADRATRO.AutoSize = true;
            BTTCADRATRO.Location = new Point(320, 350);
            BTTCADRATRO.Name = "BTTCADRATRO";
            BTTCADRATRO.Size = new Size(115, 15);
            BTTCADRATRO.TabIndex = 5;
            BTTCADRATRO.Text = "Ou cadastre-se aqui!";
            BTTCADRATRO.Click += BTTCADRATRO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTTCADRATRO);
            Controls.Add(BTTENTRAR);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(INPUTEMAIL);
            Controls.Add(INPUTSENHA);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox INPUTSENHA;
        private TextBox INPUTEMAIL;
        private Label label1;
        private Label label2;
        private Button BTTENTRAR;
        private Label BTTCADRATRO;
    }
}
