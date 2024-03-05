using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculos
{
    public partial class frmCalculos : Form
    {
        public frmCalculos()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "+";

                a = double.Parse(txtboxN1.Text);
                b = double.Parse(txtboxN2.Text);

                r = a + b;
                lblResultado.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "-";

                a = double.Parse(txtboxN1.Text);
                b = double.Parse(txtboxN2.Text);

                r = a - b;
                lblResultado.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "*";

                a = double.Parse(txtboxN1.Text);
                b = double.Parse(txtboxN2.Text);

                r = a * b;
                lblResultado.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "/";

                a = double.Parse(txtboxN1.Text);
                b = double.Parse(txtboxN2.Text);
                if (b == 0)
                {
                    MessageBox.Show("Impossível dividir por zero!");
                }

                r = a / b;
                lblResultado.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnPontenciacao_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "^";

                a = double.Parse(txtboxN1.Text);
                b = double.Parse(txtboxN2.Text);

                r = Math.Pow(a, b);

                lblResultado.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Informe apenas números!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtboxN1.Clear();
            txtboxN2.Clear();
            lblResultado.Text = "?";
            lblSinal.Text = "?";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}