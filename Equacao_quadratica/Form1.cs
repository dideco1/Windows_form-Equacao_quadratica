using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equacao_quadratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_delta.Text = "";
            lbl_x1.Text = "";
            lbl_x2.Text = "";
            txt_valor_a.Clear();
            txt_valor_b.Clear();
            txt_valor_c.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_valor_a.Text);
            double b = double.Parse(txt_valor_b.Text);
            double c = double.Parse(txt_valor_c.Text);
            double delta, x1, x2;

            if (a == 0)
            {
                MessageBox.Show("Valor 'a' não pode ser igual a 0",
                                "Dê outro valor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            delta = (b * b) - 4 * a * c;
            if (delta == 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = x1;
                lbl_delta.Text = delta.ToString("F2");
                lbl_x1.Text = x1.ToString("F2");
                lbl_x2.Text = x2.ToString("F2");
            }
            else if (delta < 0)
            {
                lbl_delta.Text = delta.ToString("F2");
                MessageBox.Show("Equação impossível de resolver",
                                "AVISO!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                lbl_delta.Text = delta.ToString("F2");
                lbl_x1.Text = x1.ToString("F2");
                lbl_x2.Text = x2.ToString("F2");
            }

        }
    }
}
