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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textInput = new System.Windows.Forms.TextBox();
            this.cmbSourceLanguage = new System.Windows.Forms.ComboBox();
            this.cmbTargetLanguage = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.btnTraduzir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.textInput);
            this.panel1.Location = new System.Drawing.Point(65, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 360);
            this.panel1.TabIndex = 2;
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.ForeColor = System.Drawing.Color.White;
            this.textInput.Location = new System.Drawing.Point(20, 20);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(360, 320);
            this.textInput.TabIndex = 12;
            this.textInput.Text = "Digite Aqui...";
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.DropDownHeight = 306;
            this.cmbSourceLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSourceLanguage.FormattingEnabled = true;
            this.cmbSourceLanguage.IntegralHeight = false;
            this.cmbSourceLanguage.Location = new System.Drawing.Point(65, 109);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(400, 24);
            this.cmbSourceLanguage.TabIndex = 4;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.DropDownWidth = 400;
            this.cmbTargetLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTargetLanguage.FormattingEnabled = true;
            this.cmbTargetLanguage.IntegralHeight = false;
            this.cmbTargetLanguage.ItemHeight = 16;
            this.cmbTargetLanguage.Location = new System.Drawing.Point(529, 109);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(400, 24);
            this.cmbTargetLanguage.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.textOutput);
            this.panel2.Location = new System.Drawing.Point(529, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 360);
            this.panel2.TabIndex = 9;
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.ForeColor = System.Drawing.Color.White;
            this.textOutput.Location = new System.Drawing.Point(20, 20);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(360, 320);
            this.textOutput.TabIndex = 10;
            this.textOutput.Text = "Texto Traduzido...";
            // 
            // btnTraduzir
            // 
            this.btnTraduzir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.btnTraduzir.FlatAppearance.BorderSize = 0;
            this.btnTraduzir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraduzir.ForeColor = System.Drawing.Color.White;
            this.btnTraduzir.Location = new System.Drawing.Point(407, 533);
            this.btnTraduzir.Name = "btnTraduzir";
            this.btnTraduzir.Size = new System.Drawing.Size(188, 43);
            this.btnTraduzir.TabIndex = 11;
            this.btnTraduzir.Text = "TRADUZIR";
            this.btnTraduzir.UseVisualStyleBackColor = false;
            this.btnTraduzir.Click += new System.EventHandler(this.btnTraduzir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "APLICATIVO DE TRADUZIR ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(613, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "em tempo real";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Translate.Properties.Resources.troca__1_;
            this.pictureBox1.Location = new System.Drawing.Point(480, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(984, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTraduzir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.panel1);
            this.Name = "Translate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo de Traduzir";
            this.Load += new System.EventHandler(this.Translate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSourceLanguage;
        private System.Windows.Forms.ComboBox cmbTargetLanguage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button btnTraduzir;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

