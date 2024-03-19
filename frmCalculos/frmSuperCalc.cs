
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

        private decimal dc;
        private string vop, Operacao;
        private Boolean Limpa;

        private void frmSuperCalc_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Return)
            {
                Close();
            }
            Button Bot = new Button();
            string tecla = e.KeyCode.ToString();
            if(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                Bot.Text = tecla.Substring(6, 1);
                f_numeros(Bot, e);
            }
            else
            {
                switch(e.KeyCode.ToString())
                {
                    case "Add":
                        {
                            Bot.Text = "+";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Subtract":
                        {
                            Bot.Text = "-";
                            f_operacoes(Bot, e);
                            break;
                        }
                    case "Divide":
                        {
                            Bot.Text = "/";
                            f_operacoes(Bot, e);
                            break;
                        }
                    /*case "Add":
                        {
                            Bot.Text = "+";
                            f_operacoes(Bot, e);
                            break;
                        }*/
                    case "Return":
                        {
                            btnIgual_Click(sender, e);
                            break;
                        }
                }
            }
        }

        private void f_numeros(object sender, EventArgs e)
        {
            lblVisor.Text = "";
            Limpa = false;
            string numero = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Bisque;
            if (lblVisor.Text == "0") lblVisor.Text = "";
            
            if(numero != "," || (numero == "," && !lblVisor.Text.Contains(",")))
            {
                lblVisor.Text += numero;
            }
            this.Focus();
        }

        private void f_operacoes(object sender, EventArgs e)
        {
            decimal NumAtual = decimal.Parse(lblVisor.Text);
            Operacao = ((Button)sender).Text;
            decimal NumAnt = decimal.Parse(lblHist.Text);
            if (Operacao == "+")
            {
                lblHist.Text += " " + NumAtual + " + ";
                lblVisor.Text = "";
                Limpa = true;
            }
            else if (Operacao == "-")
            {
                lblHist.Text += " " + NumAtual + " - ";
                lblVisor.Text = "";
                Limpa = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal NumAtual = decimal.Parse(lblVisor.Text);
            Operacao = ((Button)sender).Text;
            decimal NumAnt = decimal.Parse(lblHist.Text);

            switch (Operacao)
            {
                case "+":
                    {
                        lblVisor.Text = (NumAnt + NumAtual).ToString();
                        lblHist.Text += NumAtual + " = ";
                        break;
                    }
                case "-":
                    {
                        lblVisor.Text = (NumAnt - NumAtual).ToString();
                        lblHist.Text += NumAtual + " = ";
                        break;
                    }
                case "*":
                    {
                        lblVisor.Text = (NumAnt * NumAtual).ToString();
                        lblHist.Text += NumAtual + " = ";
                        break;
                    }
                case "/":
                    {
                        lblVisor.Text = (NumAnt / NumAtual).ToString();
                        lblHist.Text += NumAtual + " = ";
                        break;
                    }
            }
        }
    }
}
