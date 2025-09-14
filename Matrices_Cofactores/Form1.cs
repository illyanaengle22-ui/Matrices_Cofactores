using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrices_Cofactores
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
         
            GP2x2.Hide();
            GB3x3.Hide();
            rd2x2.Checked = false;
            rd3x3.Checked = false;

        }
        private void rd2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2x2.Checked)
            {
                GP2x2.Show();
                GB3x3.Hide(); 
            }
        }

        private void rd3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd3x3.Checked)
            {
                GB3x3.Show(); 
                GP2x2.Hide();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (rd2x2.Checked)
            {
                txtA11.Clear();
                txtA12.Clear();
                txtA21.Clear();
                txtA22.Clear();
            }
            else if (rd3x3.Checked)
            {
                txtA11_3x3.Clear();
                txtA12_3x3.Clear();
                txtA13.Clear();
                txtA21_3x3.Clear();
                txtA22_3x3.Clear ();
                txtA23.Clear();
                txtA31.Clear();
                txtA32.Clear();
                txtA33.Clear();
            }
           
        }

        private void btnCeros_Click(object sender, EventArgs e)
        {
            if (rd2x2.Checked)
            {
                LlenarCeros(txtA11, e);
                LlenarCeros(txtA12, e);
                LlenarCeros(txtA21, e);
                LlenarCeros(txtA22, e);
            }
            else if (rd3x3.Checked)
            {
                LlenarCeros(txtA11_3x3, e);
                LlenarCeros(txtA12_3x3, e);
                LlenarCeros(txtA13, e);
                LlenarCeros(txtA21_3x3, e);
                LlenarCeros(txtA22_3x3, e);
                LlenarCeros(txtA23, e);
                LlenarCeros(txtA31, e);
                LlenarCeros(txtA32, e);
                LlenarCeros(txtA33, e);
            }

        

        }
        private void LlenarCeros (object sender, EventArgs e)
        {
         
            TextBox txtbox = (TextBox)sender;
            if (string.IsNullOrEmpty(txtbox.Text))
            {
                txtbox.Text = "0";
            }
        }
        private static double CalcularDet2x2(double[][] m)
        {
            return
                (m[0][0] * m[1][1]
                - m[0][1] * m[1][0]);
            
        }
        private static double CalcularDet3x3(double[][] m)
        {

            var a = m[0][0];
            var b = m[0][1];
            var c = m[0][2];


            var efhi = new double[][]
            {
                new double [] {m[1][1], m[1][2] },
                new double [] { m[2][1], m[2][2] }
            };
               var dfgi = new double[][]
            {
                new double [] {m[1][0], m[1][2] },
                new double [] { m[2][0], m[2][2] }
            };
               var degh = new double[][]
            {
                new double [] {m[1][0], m[1][1] },
                new double [] { m[2][0], m[2][1] }
            };
            double det = (
                a * CalcularDet2x2(efhi)
                -b * CalcularDet2x2(dfgi)
                +c * CalcularDet2x2(degh));
            return det;

        }
        private void Det2x2()
        {
            double[][] m = new double[2][];
            m[0] = new double[2];
            m[1] = new double[2];

            m[0][0] = double.Parse(txtA11.Text);
            m[0][1] = double.Parse(txtA12.Text);
            m[1][0] = double.Parse(txtA21.Text);
            m[1][1] = double.Parse(txtA22.Text);

            double det = CalcularDet2x2(m);
            if (det != 0)
            {
                lblDet.Text = det.ToString();
                MessageBox.Show("Determinante = " + det.ToString()); 
            }
            else
            {
                MessageBox.Show("No tiene solucion Determinante = " + det.ToString());
            }
        }
        private void Det3x3()
        {
            double[][] m = new double[3][];
            m[0] = new double[3];
            m[1] = new double[3];
            m[2] = new double[3];

            m[0][0] = double.Parse(txtA11_3x3.Text);
            m[0][1] = double.Parse(txtA12_3x3.Text);
            m[0][2] = double.Parse(txtA13.Text);
            m[1][0] = double.Parse(txtA21_3x3.Text);
            m[1][1] = double.Parse(txtA22_3x3.Text);
            m[1][2] = double.Parse(txtA23.Text);
            m[2][0] = double.Parse(txtA31.Text);
            m[2][1] = double.Parse(txtA32.Text);
            m[2][2] = double.Parse(txtA33.Text);

            double det = CalcularDet3x3(m);
            if (det != 0)
            {
                MessageBox.Show("Determinante = " + det.ToString());
            }
            else
            {
                MessageBox.Show("No tiene solucion Determinante = " + det.ToString());
            }
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rd2x2.Checked && GP2x2.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Ingrese todos los datos del 2x2");
                return;
            }
            else if (rd3x3.Checked && GB3x3.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Ingrese todos los datos del 3x3");
                return;
            }

            else
            {
                if (rd2x2.Checked)
                {
                    var ms = MessageBox.Show("Antes de continuar compruebe dos veces", "Desea Continuar?", MessageBoxButtons.YesNo);
                    if(ms == DialogResult.Yes)
                    {
                        Det2x2();
                     
                    }

                }
                if (rd3x3.Checked)
                {
                    Det3x3();
                } 
            }
        }
    }
}
