
namespace Calculadora_Unifaesp
{
    partial class Form1
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
            this.visor = new System.Windows.Forms.TextBox();
            this.btnSete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visor
            // 
            this.visor.Enabled = false;
            this.visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visor.Location = new System.Drawing.Point(12, 29);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(406, 45);
            this.visor.TabIndex = 0;
            this.visor.Text = "0";
            this.visor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(12, 104);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(66, 62);
            this.btnSete.TabIndex = 1;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(84, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 62);
            this.button5.TabIndex = 5;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 62);
            this.button6.TabIndex = 4;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(156, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 62);
            this.button7.TabIndex = 9;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(84, 240);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(66, 62);
            this.btnDois.TabIndex = 8;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(12, 240);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(66, 62);
            this.btnUm.TabIndex = 7;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(84, 308);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(66, 62);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 62);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(228, 172);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(66, 62);
            this.btnSoma.TabIndex = 12;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(228, 240);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(66, 62);
            this.btnResultado.TabIndex = 13;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 644);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.visor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox visor;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnResultado;
    }
}

