using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab17
{
    public partial class Form1 : Form
    {
        private Color regionBaseColor = Color.FromArgb(180, Color.LightBlue);
        private Color regionHoverColor = Color.FromArgb(180, Color.OrangeRed);
        private Color currentPenColor = Color.Black;
        private Region regionTop;
        private Region regionBottom;
        private Control draggedControl;
        private Point dragCursorOffset;
        private Timer animationTimer;
        private int animationStep = 0;
        private bool isAnimating = false;
        private float scale;
        private float offsetX, offsetY;
        private float radiusPx;
        private PointF c1, c2, origin;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Графическое задание (Круги)";
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.ClientSize = new Size(800, 600);
            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
            this.Paint += Form1_Paint;
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupUI();
            CalculateGeometry();
            SetupAnimation();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CalculateGeometry();
            this.Invalidate();
        }

        private void SetupUI()
        {
            Button btnColor = new Button { Text = "Выбрать цвет областей", Location = new Point(10, 10), Width = 200 };
            btnColor.Click += BtnColor_Click;
            this.Controls.Add(btnColor);
            Button btnStart = new Button { Text = "Запуск анимации", Location = new Point(220, 10), Width = 150 };
            btnStart.Click += (s, e) => { isAnimating = true; };
            this.Controls.Add(btnStart);
            Button btnStop = new Button { Text = "Остановить", Location = new Point(380, 10), Width = 150 };
            btnStop.Click += (s, e) => { isAnimating = false; };
            this.Controls.Add(btnStop);
            CreateDraggableLabel("0", 10, 10);
            CreateDraggableLabel("2", 10, 10);
            CreateDraggableLabel("-2", 10, 10);
            CreateDraggableLabel("4", 10, 10);
            CreateDraggableLabel("2", 10, 10);
            CreateDraggableLabel("-2", 10, 10);
            CreateDraggableLabel("3", 10, 10);
            UpdateLabelPositions();
        }

        private void UpdateLabelPositions()
        {
            if (origin == PointF.Empty) return;
            Action<string, float, float> setPos = (text, mx, my) =>
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label lbl && lbl.Text == text)
                    {
                        PointF screenPos = MathToScreen(mx, my);
                        lbl.Location = new Point((int)(screenPos.X - lbl.Width / 2f), (int)(screenPos.Y - lbl.Height / 2f));
                        break;
                    }
                }
            };
            setPos("0", 0, 0);
            setPos("2", 2, 0); setPos("-2", -2, 0); setPos("4", 4, 0);
            setPos("2", 0, 2); setPos("-2", 0, -2); setPos("3", 0, 3);
        }

        private void CalculateGeometry()
        {
            float padLeft = 60, padRight = 40, padTop = 60, padBottom = 40;
            float availW = this.ClientSize.Width - padLeft - padRight;
            float availH = this.ClientSize.Height - padTop - padBottom;
            float mathW = 6f, mathH = 5f;
            scale = Math.Min(availW / mathW, availH / mathH);
            float drawW = mathW * scale;
            float drawH = mathH * scale;
            offsetX = padLeft + (availW - drawW) / 2f;
            offsetY = padTop + (availH - drawH) / 2f;
            origin = MathToScreen(0, 0);
            c1 = MathToScreen(0, 0);
            c2 = MathToScreen(2, 0);
            radiusPx = 2f * scale;
            GraphicsPath pathC1 = new GraphicsPath();
            pathC1.AddEllipse(c1.X - radiusPx, c1.Y - radiusPx, radiusPx * 2, radiusPx * 2);
            GraphicsPath pathC2 = new GraphicsPath();
            pathC2.AddEllipse(c2.X - radiusPx, c2.Y - radiusPx, radiusPx * 2, radiusPx * 2);
            Region lensRegion = new Region(pathC1);
            lensRegion.Intersect(pathC2);
            RectangleF topHalf = new RectangleF(0, 0, this.ClientSize.Width, origin.Y);
            RectangleF bottomHalf = new RectangleF(0, origin.Y, this.ClientSize.Width, this.ClientSize.Height - origin.Y);
            regionTop = lensRegion.Clone();
            regionTop.Intersect(topHalf);
            regionBottom = lensRegion.Clone();
            regionBottom.Intersect(bottomHalf);
            UpdateLabelPositions();
        }

        private PointF MathToScreen(float mx, float my)
        {
            float sx = offsetX + (mx + 2f) * scale;
            float sy = offsetY + (2f - my) * scale;
            return new PointF(sx, sy);
        }

        private Label CreateDraggableLabel(string text, int x, int y)
        {
            Label lbl = new Label { Text = text, Location = new Point(x, y), BackColor = Color.Transparent, AutoSize = true, Cursor = Cursors.Hand };
            lbl.MouseDown += (s, e) => { if (e.Button == MouseButtons.Left) { draggedControl = s as Control; dragCursorOffset = e.Location; draggedControl.BringToFront(); } };
            lbl.MouseMove += (s, e) => { if (draggedControl != null && e.Button == MouseButtons.Left) { draggedControl.Left += e.X - dragCursorOffset.X; draggedControl.Top += e.Y - dragCursorOffset.Y; } };
            lbl.MouseUp += (s, e) => { draggedControl = null; };
            this.Controls.Add(lbl);
            return lbl;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = regionHoverColor;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    regionHoverColor = cd.Color;
                    this.Invalidate();
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (regionTop == null) return;
            bool isHover = regionTop.IsVisible(e.Location) || regionBottom.IsVisible(e.Location);
            this.Cursor = isHover ? Cursors.Hand : Cursors.Default;
            this.Invalidate();
        }

        private void SetupAnimation()
        {
            animationTimer = new Timer { Interval = 50 };
            animationTimer.Tick += (s, e) =>
            {
                if (isAnimating)
                {
                    animationStep++;
                    int r = (int)(127 * Math.Sin(animationStep * 0.05) + 128);
                    int g = (int)(127 * Math.Sin(animationStep * 0.05 + 2) + 128);
                    int b = (int)(127 * Math.Sin(animationStep * 0.05 + 4) + 128);
                    currentPenColor = Color.FromArgb(r, g, b);
                    this.Invalidate();
                }
            };
            animationTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (regionTop == null) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(this.BackColor);
            PointF mousePos = this.PointToClient(MousePosition);
            bool isHoverTop = regionTop.IsVisible(mousePos);
            bool isHoverBottom = regionBottom.IsVisible(mousePos);
            g.FillRegion(isHoverTop ? new SolidBrush(regionHoverColor) : new SolidBrush(regionBaseColor), regionTop);
            g.FillRegion(isHoverBottom ? new SolidBrush(regionHoverColor) : new SolidBrush(regionBaseColor), regionBottom);
            Pen pen = new Pen(currentPenColor, 2f);
            g.DrawLine(pen, offsetX, origin.Y, offsetX + 6 * scale, origin.Y);
            g.DrawLine(pen, origin.X, offsetY, origin.X, offsetY + 5 * scale);
            g.FillPolygon(new SolidBrush(currentPenColor), new PointF[] { new PointF(offsetX + 6 * scale, origin.Y), new PointF(offsetX + 6 * scale - 10, origin.Y - 5), new PointF(offsetX + 6 * scale - 10, origin.Y + 5) });
            g.FillPolygon(new SolidBrush(currentPenColor), new PointF[] { new PointF(origin.X, offsetY), new PointF(origin.X - 5, offsetY + 10), new PointF(origin.X + 5, offsetY + 10) });
            g.DrawEllipse(pen, c1.X - radiusPx, c1.Y - radiusPx, radiusPx * 2, radiusPx * 2);
            g.DrawEllipse(pen, c2.X - radiusPx, c2.Y - radiusPx, radiusPx * 2, radiusPx * 2);
            if (isAnimating)
            {
                float fontSize = 14f + 4f * (float)Math.Sin(animationStep * 0.1);
                Font animFont = new Font("Arial", fontSize, FontStyle.Italic);
                g.DrawString("x", animFont, new SolidBrush(currentPenColor), offsetX + 6 * scale - 5, origin.Y + 10);
                g.DrawString("y", animFont, new SolidBrush(currentPenColor), origin.X + 10, offsetY - 5);
            }
            else
            {
                Font staticFont = new Font("Arial", 14f, FontStyle.Italic);
                g.DrawString("x", staticFont, Brushes.Black, offsetX + 6 * scale - 5, origin.Y + 10);
                g.DrawString("y", staticFont, Brushes.Black, origin.X + 10, offsetY - 5);
            }
        }
    }
}