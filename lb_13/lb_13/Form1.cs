using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbEq1.CheckedChanged += RadioButton_CheckedChanged;
            rbEq2.CheckedChanged += RadioButton_CheckedChanged;
            rbEq3.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool isThirdEquation = rbEq3.Checked;

            lblR.Visible = isThirdEquation;
            txtR.Visible = isThirdEquation;

            if (isThirdEquation)
            {
                lblX.Text = "x";
                lblY.Text = "a";
                lblW.Text = "f";
                lblT.Text = "b";
                lblN.Text = "n";
            }
            else
            {
                lblX.Text = "X";
                lblY.Text = "Y";
                lblW.Text = "W";
                lblT.Text = "T";
                lblN.Text = "N";
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(txtX.Text);
                double Y = Convert.ToDouble(txtY.Text);
                int N = Convert.ToInt32(txtN.Text);
                double W = Convert.ToDouble(cmbW.SelectedItem.ToString());
                double T = Convert.ToDouble(cmbT.SelectedItem.ToString());

                double Zoo = 0;

                if (rbEq1.Checked)
                {
                    for (int i = 0; i < N; i++)
                    {
                        double item = (i % 2 == 0) ? Y : X;
                        Zoo += Math.Pow(-1, i % 2) * Math.Pow(item, i);
                    }
                }
                else if (rbEq2.Checked)
                {
                    Zoo = W * X - T * Y + 7;
                }
                else if (rbEq3.Checked)
                {
                    double r = Convert.ToDouble(txtR.Text.Replace('.', ','));
                    double sum = 0;
                    for (int i = 1; i <= N; i++)
                        for (int j = 1; j <= (int)r; j++)
                            sum += (Y * (i + j)) / (T * i * (i + 2));
                    Zoo = sum;
                }
                else
                {
                    txtZoo.Text = "Выберите уравнение";
                    return;
                }

                txtZoo.Text = Zoo.ToString("F4");
            }
            catch (Exception ex)
            {
                txtZoo.Text = "Ошибка ввода: " + ex.Message;
            }
        }
    }
}