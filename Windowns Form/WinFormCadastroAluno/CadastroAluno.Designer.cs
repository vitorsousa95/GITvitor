namespace WinFormCadastroAluno
{
    partial class CadastroAluno
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.nrIdade = new System.Windows.Forms.NumericUpDown();
            this.bSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idade:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(91, 13);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(384, 22);
            this.tbxNome.TabIndex = 2;
            // 
            // nrIdade
            // 
            this.nrIdade.Location = new System.Drawing.Point(91, 51);
            this.nrIdade.Name = "nrIdade";
            this.nrIdade.Size = new System.Drawing.Size(76, 22);
            this.nrIdade.TabIndex = 3;
            // 
            // bSalvar
            // 
            this.bSalvar.Location = new System.Drawing.Point(248, 49);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(227, 23);
            this.bSalvar.TabIndex = 4;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.BSalvar_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(493, 98);
            this.ControlBox = false;
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.nrIdade);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            ((System.ComponentModel.ISupportInitialize)(this.nrIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.NumericUpDown nrIdade;
        private System.Windows.Forms.Button bSalvar;
    }
}