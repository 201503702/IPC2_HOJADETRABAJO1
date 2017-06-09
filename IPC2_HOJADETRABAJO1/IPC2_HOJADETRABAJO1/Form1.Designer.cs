namespace IPC2_HOJADETRABAJO1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnHipotenusa = new System.Windows.Forms.Button();
            this.txtLadoY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLadoX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.btnVocales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVocales = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.btnHipotenusa);
            this.groupBox1.Controls.Add(this.txtLadoY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLadoX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular Hipotenusa";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(64, 133);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(65, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "lblResultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // btnHipotenusa
            // 
            this.btnHipotenusa.Location = new System.Drawing.Point(56, 94);
            this.btnHipotenusa.Name = "btnHipotenusa";
            this.btnHipotenusa.Size = new System.Drawing.Size(75, 23);
            this.btnHipotenusa.TabIndex = 4;
            this.btnHipotenusa.Text = "Calcular";
            this.btnHipotenusa.UseVisualStyleBackColor = true;
            this.btnHipotenusa.Click += new System.EventHandler(this.btnHipotenusa_Click);
            // 
            // txtLadoY
            // 
            this.txtLadoY.Location = new System.Drawing.Point(67, 59);
            this.txtLadoY.Name = "txtLadoY";
            this.txtLadoY.Size = new System.Drawing.Size(100, 20);
            this.txtLadoY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lado Y:";
            // 
            // txtLadoX
            // 
            this.txtLadoX.Location = new System.Drawing.Point(67, 28);
            this.txtLadoX.Name = "txtLadoX";
            this.txtLadoX.Size = new System.Drawing.Size(100, 20);
            this.txtLadoX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultado2);
            this.groupBox2.Controls.Add(this.btnVocales);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVocales);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contiene Vocales";
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(51, 133);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(71, 13);
            this.lblResultado2.TabIndex = 3;
            this.lblResultado2.Text = "lblResultado2";
            this.lblResultado2.Visible = false;
            // 
            // btnVocales
            // 
            this.btnVocales.Location = new System.Drawing.Point(34, 94);
            this.btnVocales.Name = "btnVocales";
            this.btnVocales.Size = new System.Drawing.Size(111, 23);
            this.btnVocales.TabIndex = 2;
            this.btnVocales.Text = "Evaluar Palabra";
            this.btnVocales.UseVisualStyleBackColor = true;
            this.btnVocales.Click += new System.EventHandler(this.btnVocales_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Palabra a evaluar:";
            // 
            // txtVocales
            // 
            this.txtVocales.Location = new System.Drawing.Point(20, 59);
            this.txtVocales.Name = "txtVocales";
            this.txtVocales.Size = new System.Drawing.Size(139, 20);
            this.txtVocales.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 192);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnHipotenusa;
        private System.Windows.Forms.TextBox txtLadoY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLadoX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button btnVocales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVocales;
    }
}

