namespace Criptografia_Cesar
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.encriptar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.decriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(430, 22);
            this.textBox3.TabIndex = 2;
            // 
            // encriptar
            // 
            this.encriptar.Location = new System.Drawing.Point(139, 234);
            this.encriptar.Name = "encriptar";
            this.encriptar.Size = new System.Drawing.Size(75, 23);
            this.encriptar.TabIndex = 3;
            this.encriptar.Text = "encriptar";
            this.encriptar.UseVisualStyleBackColor = true;
            this.encriptar.Click += new System.EventHandler(this.encriptar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(139, 205);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(156, 23);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // decriptar
            // 
            this.decriptar.Location = new System.Drawing.Point(220, 234);
            this.decriptar.Name = "decriptar";
            this.decriptar.Size = new System.Drawing.Size(75, 23);
            this.decriptar.TabIndex = 5;
            this.decriptar.Text = "decriptar";
            this.decriptar.UseVisualStyleBackColor = true;
            this.decriptar.Click += new System.EventHandler(this.decriptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 293);
            this.Controls.Add(this.decriptar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.encriptar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button encriptar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button decriptar;
    }
}

