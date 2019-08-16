namespace CadastroDeLanche
{
    partial class TelaDeCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.nrQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(101, 9);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(252, 22);
            this.tbxNome.TabIndex = 3;
            // 
            // nrQuantidade
            // 
            this.nrQuantidade.Location = new System.Drawing.Point(101, 37);
            this.nrQuantidade.Name = "nrQuantidade";
            this.nrQuantidade.Size = new System.Drawing.Size(252, 22);
            this.nrQuantidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor R$:";
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(101, 63);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(252, 22);
            this.tbxValor.TabIndex = 7;
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 190);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nrQuantidade);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "TelaDeCadastro";
            this.Text = "TelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.nrQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.NumericUpDown nrQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxValor;
    }
}