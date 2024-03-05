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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Calculadora1_Click(object sender, EventArgs e)
        {
            frmCalculos objCalc = new frmCalculos();
            //Definir
            objCalc.MdiParent = this;
            //Mostrar o form
            objCalc.Show();
        }

        private void Troca_Wallpaper_Click(object sender, EventArgs e)
        {
            frmCalculos objCalc = new frmCalculos();
            //Definir
            objCalc.MdiParent = this;
            //Mostrar o form
            objCalc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
