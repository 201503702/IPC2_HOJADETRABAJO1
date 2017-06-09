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

        private void btnVocales_Click(object sender, EventArgs e)
        {
            if (txtVocales.Text.Trim().Length > 0)
            {
                String[] vocales = new String[] { "a", "e", "i", "o", "u" };
                int contador = 0;
                String cadena = txtVocales.Text.
                                           Trim().
                                           ToLower().
                                           Replace("á", "a").
                                           Replace("é", "e").
                                           Replace("í", "i").
                                           Replace("ó", "o").
                                           Replace("ú", "u");
                for (int c = 0; c < vocales.Length; c++)
                {
                    contador += (cadena.IndexOf(vocales[c]) != -1) ? 1 : 0;
                }

                if (contador > 4)
                {
                    lblResultado2.Text = "La palabra es valida";
                }
                else
                {
                    lblResultado2.Text = "La palabra es invalida";
                }

                lblResultado2.Visible = true;
            }
        }

        private void btnVoltear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                char[] nombre = txtNombre.Text.Trim().ToCharArray();
                String resultado = "";

                for (int letra = txtNombre.Text.Length - 1; letra >= 0; letra--)
                {
                    resultado += nombre[letra];
                }

                lblResultado3.Text = "El resultado es: " + resultado;
                lblResultado3.Visible = true;
            }
        }
    }
}
