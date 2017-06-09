using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPC2_HOJADETRABAJO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHipotenusa_Click(object sender, EventArgs e)
        {
            if (txtLadoX.Text.Trim().Length > 0 && txtLadoY.Text.Trim().Length > 0)
            {
                double x = 0.0, y = 0.0;
                double hipotenusa = 0.0;
                x = double.Parse(txtLadoX.Text);
                y = double.Parse(txtLadoY.Text);
                hipotenusa = Math.Sqrt((x * x) + (y * y));
                lblResultado.Text = "La hipotenusa es: " + hipotenusa.ToString();
                lblResultado.Visible = true;
            }
        }
    }
}
