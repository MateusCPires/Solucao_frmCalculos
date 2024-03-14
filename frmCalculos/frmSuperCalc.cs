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

        private void f_operacoes(object sender,  EventArgs e)
        {
            int NumAnt, NumAtual;
            NumAnt = decimal.Parse(lblVisor.Text);

            switch (Operacao)
            {
                case "+":
                    {
                        lblVisor.Text = (NumAnt + NumAtual)
                    }
            }
        }
    }
}
