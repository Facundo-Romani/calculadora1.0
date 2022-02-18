namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSumar.Location = new System.Drawing.Point(49, 195);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(57, 53);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(135, 195);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(57, 53);
            this.btnRestar.TabIndex = 1;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(226, 195);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(57, 53);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(328, 195);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(57, 53);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(54, 266);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(138, 41);
            this.txtNumero1.TabIndex = 4;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(247, 266);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(138, 41);
            this.txtNumero2.TabIndex = 5;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(164, 126);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 46);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(430, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
    }
}

