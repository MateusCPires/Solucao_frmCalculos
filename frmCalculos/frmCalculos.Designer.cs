
namespace frmCalculos
{
    partial class frmCalculos
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnPontenciacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtboxN2 = new System.Windows.Forms.TextBox();
            this.txtboxN1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(337, 411);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(134, 38);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(141, 345);
            this.btnDividir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(134, 38);
            this.btnDividir.TabIndex = 55;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnPontenciacao
            // 
            this.btnPontenciacao.Location = new System.Drawing.Point(337, 345);
            this.btnPontenciacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPontenciacao.Name = "btnPontenciacao";
            this.btnPontenciacao.Size = new System.Drawing.Size(134, 38);
            this.btnPontenciacao.TabIndex = 53;
            this.btnPontenciacao.Text = "Potenciação";
            this.btnPontenciacao.UseVisualStyleBackColor = true;
            this.btnPontenciacao.Click += new System.EventHandler(this.btnPontenciacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(240, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "________________________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblResultado.Location = new System.Drawing.Point(395, 233);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(25, 27);
            this.lblResultado.TabIndex = 51;
            this.lblResultado.Text = "?";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxN2
            // 
            this.txtboxN2.Location = new System.Drawing.Point(241, 151);
            this.txtboxN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxN2.Name = "txtboxN2";
            this.txtboxN2.Size = new System.Drawing.Size(328, 26);
            this.txtboxN2.TabIndex = 50;
            // 
            // txtboxN1
            // 
            this.txtboxN1.Location = new System.Drawing.Point(241, 93);
            this.txtboxN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxN1.Name = "txtboxN1";
            this.txtboxN1.Size = new System.Drawing.Size(328, 26);
            this.txtboxN1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(233, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 55);
            this.label4.TabIndex = 48;
            this.label4.Text = "Calculadora 3.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(525, 345);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(134, 38);
            this.btnLimpar.TabIndex = 47;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(337, 281);
            this.btnSubtrair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(134, 38);
            this.btnSubtrair.TabIndex = 46;
            this.btnSubtrair.Text = "Subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.Color.Transparent;
            this.lblSinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSinal.Location = new System.Drawing.Point(203, 151);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(25, 27);
            this.lblSinal.TabIndex = 45;
            this.lblSinal.Text = "?";
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(141, 281);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(134, 38);
            this.btnSomar.TabIndex = 44;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(525, 281);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(134, 38);
            this.btnMultiplicar.TabIndex = 54;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // frmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frmCalculos.Properties.Resources._360_F_291719619_lyQS5pyFo3Wj43hy83o3R0oOxhaep9fQ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPontenciacao);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtboxN2);
            this.Controls.Add(this.txtboxN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.btnSomar);
            this.Name = "frmCalculos";
            this.Text = "Cálculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnPontenciacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtboxN2;
        private System.Windows.Forms.TextBox txtboxN1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
    }
}

