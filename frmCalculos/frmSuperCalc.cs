
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
    public partial class frmSuperCalc : Form
    {
        public frmSuperCalc()
        {
            InitializeComponent();
        }

        private void frmSuperCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Close();
            }
        }

        private void Numeros(object sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            if (lblVisor.Text == "0") lblVisor.Text = "";
            
            if(numero != "," || (numero == "," && !lblVisor.Text.Contains(",")))
            {
                lblVisor.Text += numero;
            }

        }

        private decimal dc;
        private string vop;
        private Boolean vlimpa;

        private void f_operacoes(object sender, EventArgs e)
        {

        }
    }
}
