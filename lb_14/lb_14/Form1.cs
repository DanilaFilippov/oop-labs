using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb_14
{
    public partial class Form1 : Form
    {
        private bool showTime = true;
        private int selectedMouseExpression = 1;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.MouseMove += Form1_MouseMove;
            this.FormClosing += Form1_FormClosing;
            timer1.Tick += Timer1_Tick;

            tscbColorPreset.SelectedIndexChanged += (s, e) => ChangeColorFromCombo();
            tsbRed.TextChanged += (s, e) => ApplyRgbColor();
            tsbGreen.TextChanged += (s, e) => ApplyRgbColor();
            tsbBlue.TextChanged += (s, e) => ApplyRgbColor();

            tsmiExit.Click += (s, e) => Application.Exit();
            ctxExit.Click += (s, e) => Application.Exit();

            tsmiCompute.Click += TsmiCompute_Click;
            ctxCompute.Click += TsmiCompute_Click;

            SyncTextBoxes(tsbX, ctxX);
            SyncTextBoxes(tsbY, ctxY);
            SyncTextBoxes(tsbZ, ctxZ);
            SyncComboBoxes(tscbA, ctxA);
            SyncComboBoxes(tscbB, ctxB);
            SyncComboBoxes(tscbColorPreset, ctxColorCombo);
            SyncColorTextBoxes(tsbRed, ctxRed);
            SyncColorTextBoxes(tsbGreen, ctxGreen);
            SyncColorTextBoxes(tsbBlue, ctxBlue);

            var expr1 = new ToolStripMenuItem("(y - sqrt(x)) / |x - y|");
            var expr2 = new ToolStripMenuItem("sqrt( | sqrt(x) - sqrt(y) | )");
            var expr3 = new ToolStripMenuItem("cos(x^2) + sin^2(y)");
            expr1.Click += (s, e) => { selectedMouseExpression = 1; UpdateMouseExpression(); };
            expr2.Click += (s, e) => { selectedMouseExpression = 2; UpdateMouseExpression(); };
            expr3.Click += (s, e) => { selectedMouseExpression = 3; UpdateMouseExpression(); };
            tsddbExpression.DropDownItems.Add(expr1);
            tsddbExpression.DropDownItems.Add(expr2);
            tsddbExpression.DropDownItems.Add(expr3);

            tscbA.SelectedIndex = 0;
            tscbB.SelectedIndex = 1;
            ctxA.SelectedIndex = 0;
            ctxB.SelectedIndex = 1;
            tscbColorPreset.SelectedIndex = 0;
            ctxColorCombo.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDateTime();
            timer1.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            sslCoords.Text = $"X: {e.X}, Y: {e.Y}";
            UpdateMouseExpression(e.X, e.Y);
        }

        private void UpdateMouseExpression()
        {
            Point p = this.PointToClient(MousePosition);
            UpdateMouseExpression(p.X, p.Y);
        }

        private void UpdateMouseExpression(int x, int y)
        {
            double result = 0;
            bool valid = true;
            switch (selectedMouseExpression)
            {
                case 1:
                    if (x < 0 || Math.Abs(x - y) < 1e-10) valid = false;
                    else result = (y - Math.Sqrt(x)) / Math.Abs(x - y);
                    break;
                case 2:
                    if (x < 0 || y < 0) valid = false;
                    else result = Math.Sqrt(Math.Abs(Math.Sqrt(x) - Math.Sqrt(y)));
                    break;
                case 3:
                    result = Math.Cos(x * x) + Math.Pow(Math.Sin(y), 2);
                    break;
            }
            if (valid)
                sslMouseResult.Text = $"Результат: {result:F4}";
            else
                sslMouseResult.Text = "Ошибка (деление на 0 или корень)";
        }

        private void TsmiCompute_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tsbX.Text.Replace('.', ','));
                double y = double.Parse(tsbY.Text.Replace('.', ','));
                double z = double.Parse(tsbZ.Text.Replace('.', ','));
                double a = double.Parse(tscbA.SelectedItem.ToString().Replace('.', ','));
                double b = double.Parse(tscbB.SelectedItem.ToString().Replace('.', ','));

                if (a * z <= 0)
                {
                    this.Text = "Ошибка: a*z <= 0 (логарифм не определён)";
                    return;
                }

                double result = a * Math.Pow(x, 2) + b * (y - x) + Math.Log10(a * z);
                this.Text = $"Результат: {result:F4}";
            }
            catch
            {
                this.Text = "Ошибка ввода";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e) => UpdateDateTime();
        private void UpdateDateTime()
        {
            sslDateTime.Text = showTime ? DateTime.Now.ToLongTimeString() : DateTime.Now.ToLongDateString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => timer1.Stop();

        private void ChangeColorFromCombo()
        {
            switch (tscbColorPreset.SelectedItem.ToString())
            {
                case "Белый": BackColor = Color.White; break;
                case "Красный": BackColor = Color.Red; break;
                case "Зелёный": BackColor = Color.Green; break;
                case "Синий": BackColor = Color.Blue; break;
            }
            ctxColorCombo.SelectedIndex = tscbColorPreset.SelectedIndex;
        }

        private void ApplyRgbColor()
        {
            try
            {
                int r = int.Parse(tsbRed.Text);
                int g = int.Parse(tsbGreen.Text);
                int b = int.Parse(tsbBlue.Text);
                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    BackColor = Color.FromArgb(r, g, b);
                    ctxRed.Text = r.ToString();
                    ctxGreen.Text = g.ToString();
                    ctxBlue.Text = b.ToString();
                }
            }
            catch { }
        }

        private void SyncTextBoxes(ToolStripTextBox main, ToolStripTextBox ctx)
        {
            main.TextChanged += (s, e) => ctx.Text = main.Text;
            ctx.TextChanged += (s, e) => main.Text = ctx.Text;
        }
        private void SyncComboBoxes(ToolStripComboBox main, ToolStripComboBox ctx)
        {
            main.SelectedIndexChanged += (s, e) => ctx.SelectedIndex = main.SelectedIndex;
            ctx.SelectedIndexChanged += (s, e) => main.SelectedIndex = ctx.SelectedIndex;
        }
        private void SyncColorTextBoxes(ToolStripTextBox main, ToolStripTextBox ctx)
        {
            main.TextChanged += (s, e) => { ctx.Text = main.Text; ApplyRgbColor(); };
            ctx.TextChanged += (s, e) => { main.Text = ctx.Text; ApplyRgbColor(); };
        }
    }
}