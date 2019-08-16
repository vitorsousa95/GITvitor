namespace WinFormFormularioCarros
{
    partial class CadastroCarro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxPlaca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPlaca2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(91, 22);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(467, 22);
            this.tbxNome.TabIndex = 3;
            // 
            // tbxPlaca
            // 
            this.tbxPlaca.Location = new System.Drawing.Point(91, 115);
            this.tbxPlaca.Name = "tbxPlaca";
            this.tbxPlaca.Size = new System.Drawing.Size(55, 22);
            this.tbxPlaca.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 117);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbxPlaca2
            // 
            this.tbxPlaca2.Location = new System.Drawing.Point(175, 115);
            this.tbxPlaca2.Name = "tbxPlaca2";
            this.tbxPlaca2.Size = new System.Drawing.Size(77, 22);
            this.tbxPlaca2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " -";
            // 
            // tbxAno
            // 
            this.tbxAno.Location = new System.Drawing.Point(91, 63);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(201, 22);
            this.tbxAno.TabIndex = 9;
            // 
            // CadastroCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 176);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPlaca2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxPlaca);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCarro";
            this.Text = "CadastroCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxPlaca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxPlaca2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAno;
    }
}