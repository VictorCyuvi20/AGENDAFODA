﻿namespace AGENDAFODA.Views
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            aRQUIVOToolStripMenuItem = new ToolStripMenuItem();
            sAIRToolStripMenuItem = new ToolStripMenuItem();
            cONTATOSToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            novoContatoToolStripMenuItem = new ToolStripMenuItem();
            APENAS = new Label();
            eNCERRARSESSÃOToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aRQUIVOToolStripMenuItem, cONTATOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sAIRToolStripMenuItem, eNCERRARSESSÃOToolStripMenuItem });
            aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            aRQUIVOToolStripMenuItem.Size = new Size(70, 20);
            aRQUIVOToolStripMenuItem.Text = "&ARQUIVO";
            aRQUIVOToolStripMenuItem.Click += aRQUIVOToolStripMenuItem_Click;
            // 
            // sAIRToolStripMenuItem
            // 
            sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            sAIRToolStripMenuItem.Size = new Size(180, 22);
            sAIRToolStripMenuItem.Text = "&SAIR";
            sAIRToolStripMenuItem.Click += sAIRToolStripMenuItem_Click;
            // 
            // cONTATOSToolStripMenuItem
            // 
            cONTATOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem });
            cONTATOSToolStripMenuItem.Name = "cONTATOSToolStripMenuItem";
            cONTATOSToolStripMenuItem.Size = new Size(49, 20);
            cONTATOSToolStripMenuItem.Text = "&Editar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem, novoContatoToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(124, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(149, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // novoContatoToolStripMenuItem
            // 
            novoContatoToolStripMenuItem.Name = "novoContatoToolStripMenuItem";
            novoContatoToolStripMenuItem.Size = new Size(149, 22);
            novoContatoToolStripMenuItem.Text = "Novo Contato";
            // 
            // APENAS
            // 
            APENAS.Location = new Point(155, 63);
            APENAS.Name = "APENAS";
            APENAS.Size = new Size(427, 66);
            APENAS.TabIndex = 1;
            APENAS.Text = "label1";
            // 
            // eNCERRARSESSÃOToolStripMenuItem
            // 
            eNCERRARSESSÃOToolStripMenuItem.Name = "eNCERRARSESSÃOToolStripMenuItem";
            eNCERRARSESSÃOToolStripMenuItem.Size = new Size(180, 22);
            eNCERRARSESSÃOToolStripMenuItem.Text = "ENCERRAR SESSÃO";
            eNCERRARSESSÃOToolStripMenuItem.Click += eNCERRARSESSÃOToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(APENAS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private ToolStripMenuItem sAIRToolStripMenuItem;
        private ToolStripMenuItem cONTATOSToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem novoContatoToolStripMenuItem;
        private Label APENAS;
        private ToolStripMenuItem eNCERRARSESSÃOToolStripMenuItem;
    }
}