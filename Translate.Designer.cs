namespace Translate
{
    partial class Translate
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.TextBox textBox2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbSourceLanguage = new System.Windows.Forms.ComboBox();
            this.cbTargetLanguage = new System.Windows.Forms.ComboBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(textBox1);
            this.panel1.Location = new System.Drawing.Point(43, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 360);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.ForeColor = System.Drawing.SystemColors.Window;
            textBox1.Location = new System.Drawing.Point(20, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(320, 320);
            textBox1.TabIndex = 2;
            textBox1.Text = "Digite Aqui...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(textBox2);
            this.panel2.Location = new System.Drawing.Point(474, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 360);
            this.panel2.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.ForeColor = System.Drawing.SystemColors.Window;
            textBox2.Location = new System.Drawing.Point(20, 20);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(320, 320);
            textBox2.TabIndex = 2;
            textBox2.Text = "Texto Traduzido...";
            // 
            // cbSourceLanguage
            // 
            this.cbSourceLanguage.FormattingEnabled = true;
            this.cbSourceLanguage.Location = new System.Drawing.Point(43, 515);
            this.cbSourceLanguage.Name = "cbSourceLanguage";
            this.cbSourceLanguage.Size = new System.Drawing.Size(360, 21);
            this.cbSourceLanguage.TabIndex = 4;
            // 
            // cbTargetLanguage
            // 
            this.cbTargetLanguage.FormattingEnabled = true;
            this.cbTargetLanguage.Location = new System.Drawing.Point(474, 515);
            this.cbTargetLanguage.Name = "cbTargetLanguage";
            this.cbTargetLanguage.Size = new System.Drawing.Size(360, 21);
            this.cbTargetLanguage.TabIndex = 5;
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.Location = new System.Drawing.Point(361, 569);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(161, 29);
            this.btnTraduzir.TabIndex = 6;
            this.btnTraduzir.Text = "TRADUZIR";
            this.btnTraduzir.UseVisualStyleBackColor = true;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(884, 632);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.cbTargetLanguage);
            this.Controls.Add(this.cbSourceLanguage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Translate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbSourceLanguage;
        private System.Windows.Forms.ComboBox cbTargetLanguage;
        private System.Windows.Forms.Button btnTraduzir;
    }
}

