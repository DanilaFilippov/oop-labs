namespace lb_14
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbColorPreset = new System.Windows.Forms.ToolStripComboBox();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRed = new System.Windows.Forms.ToolStripTextBox();
            this.tsbGreen = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBlue = new System.Windows.Forms.ToolStripTextBox();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbX = new System.Windows.Forms.ToolStripTextBox();
            this.tsbY = new System.Windows.Forms.ToolStripTextBox();
            this.tsbZ = new System.Windows.Forms.ToolStripTextBox();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscbA = new System.Windows.Forms.ToolStripComboBox();
            this.tscbB = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiCalculations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompute = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsddbExpression = new System.Windows.Forms.ToolStripDropDownButton();
            this.sslMouseResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxColorCombo = new System.Windows.Forms.ToolStripComboBox();
            this.ctxSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxRed = new System.Windows.Forms.ToolStripTextBox();
            this.ctxGreen = new System.Windows.Forms.ToolStripTextBox();
            this.ctxBlue = new System.Windows.Forms.ToolStripTextBox();
            this.ctxSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxParams = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxX = new System.Windows.Forms.ToolStripTextBox();
            this.ctxY = new System.Windows.Forms.ToolStripTextBox();
            this.ctxZ = new System.Windows.Forms.ToolStripTextBox();
            this.ctxSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxA = new System.Windows.Forms.ToolStripComboBox();
            this.ctxB = new System.Windows.Forms.ToolStripComboBox();
            this.ctxCalculations = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCompute = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiColor,
            this.tsmiParams,
            this.tsmiCalculations});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.tsmiColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbColorPreset,
            this.tsSeparator1,
            this.tsbRed,
            this.tsbGreen,
            this.tsbBlue,
            this.tsSeparator2,
            this.tsmiExit});
            this.tsmiColor.Name = "tsmiColor";
            this.tsmiColor.Size = new System.Drawing.Size(48, 20);
            this.tsmiColor.Text = "Color";
            this.tscbColorPreset.Name = "tscbColorPreset";
            this.tscbColorPreset.Size = new System.Drawing.Size(121, 23);
            this.tscbColorPreset.Items.AddRange(new object[] { "Белый", "Красный", "Зелёный", "Синий" });
            this.tscbColorPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsbRed.Name = "tsbRed";
            this.tsbRed.Size = new System.Drawing.Size(100, 23);
            this.tsbRed.Text = "0";
            this.tsbRed.ToolTipText = "Красный (0-255)";
            this.tsbGreen.Name = "tsbGreen";
            this.tsbGreen.Size = new System.Drawing.Size(100, 23);
            this.tsbGreen.Text = "0";
            this.tsbGreen.ToolTipText = "Зелёный (0-255)";
            this.tsbBlue.Name = "tsbBlue";
            this.tsbBlue.Size = new System.Drawing.Size(100, 23);
            this.tsbBlue.Text = "0";
            this.tsbBlue.ToolTipText = "Синий (0-255)";
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(181, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiParams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbX,
            this.tsbY,
            this.tsbZ,
            this.tsSeparator3,
            this.tscbA,
            this.tscbB});
            this.tsmiParams.Name = "tsmiParams";
            this.tsmiParams.Size = new System.Drawing.Size(82, 20);
            this.tsmiParams.Text = "Параметры";
            this.tsbX.Name = "tsbX";
            this.tsbX.Size = new System.Drawing.Size(100, 23);
            this.tsbX.Text = "0";
            this.tsbX.ToolTipText = "x";
            this.tsbY.Name = "tsbY";
            this.tsbY.Size = new System.Drawing.Size(100, 23);
            this.tsbY.Text = "0";
            this.tsbY.ToolTipText = "y";
            this.tsbZ.Name = "tsbZ";
            this.tsbZ.Size = new System.Drawing.Size(100, 23);
            this.tsbZ.Text = "0";
            this.tsbZ.ToolTipText = "z";
            this.tscbA.Name = "tscbA";
            this.tscbA.Size = new System.Drawing.Size(100, 23);
            this.tscbA.Items.AddRange(new object[] { "1", "2", "3" });
            this.tscbA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbB.Name = "tscbB";
            this.tscbB.Size = new System.Drawing.Size(100, 23);
            this.tscbB.Items.AddRange(new object[] { "0,5", "1", "2" });
            this.tscbB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsmiCalculations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompute});
            this.tsmiCalculations.Name = "tsmiCalculations";
            this.tsmiCalculations.Size = new System.Drawing.Size(88, 20);
            this.tsmiCalculations.Text = "Вычисления";
            this.tsmiCompute.Name = "tsmiCompute";
            this.tsmiCompute.Size = new System.Drawing.Size(180, 22);
            this.tsmiCompute.Text = "Вычислить";
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslCoords,
            this.sslDateTime,
            this.tsddbExpression,
            this.sslMouseResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.sslCoords.Name = "sslCoords";
            this.sslCoords.Size = new System.Drawing.Size(118, 17);
            this.sslCoords.Text = "X: 0, Y: 0";
            this.sslCoords.Spring = true;
            this.sslDateTime.Name = "sslDateTime";
            this.sslDateTime.Size = new System.Drawing.Size(118, 17);
            this.sslDateTime.Text = "00:00:00";
            this.sslDateTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
            this.tsddbExpression.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbExpression.Name = "tsddbExpression";
            this.tsddbExpression.Size = new System.Drawing.Size(61, 20);
            this.tsddbExpression.Text = "Формула";
            this.sslMouseResult.Name = "sslMouseResult";
            this.sslMouseResult.Size = new System.Drawing.Size(118, 17);
            this.sslMouseResult.Text = "Выберите формулу";
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxColor,
            this.ctxParams,
            this.ctxCalculations});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.ctxColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxColorCombo,
            this.ctxSeparator1,
            this.ctxRed,
            this.ctxGreen,
            this.ctxBlue,
            this.ctxSeparator2,
            this.ctxExit});
            this.ctxColor.Name = "ctxColor";
            this.ctxColor.Size = new System.Drawing.Size(152, 22);
            this.ctxColor.Text = "Color";
            this.ctxColorCombo.Name = "ctxColorCombo";
            this.ctxColorCombo.Size = new System.Drawing.Size(121, 23);
            this.ctxColorCombo.Items.AddRange(new object[] { "Белый", "Красный", "Зелёный", "Синий" });
            this.ctxColorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxRed.Name = "ctxRed";
            this.ctxRed.Size = new System.Drawing.Size(100, 23);
            this.ctxRed.Text = "0";
            this.ctxGreen.Name = "ctxGreen";
            this.ctxGreen.Size = new System.Drawing.Size(100, 23);
            this.ctxGreen.Text = "0";
            this.ctxBlue.Name = "ctxBlue";
            this.ctxBlue.Size = new System.Drawing.Size(100, 23);
            this.ctxBlue.Text = "0";
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(152, 22);
            this.ctxExit.Text = "Выход";
            this.ctxParams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxX,
            this.ctxY,
            this.ctxZ,
            this.ctxSeparator3,
            this.ctxA,
            this.ctxB});
            this.ctxParams.Name = "ctxParams";
            this.ctxParams.Size = new System.Drawing.Size(152, 22);
            this.ctxParams.Text = "Параметры";
            this.ctxX.Name = "ctxX";
            this.ctxX.Size = new System.Drawing.Size(100, 23);
            this.ctxX.Text = "0";
            this.ctxY.Name = "ctxY";
            this.ctxY.Size = new System.Drawing.Size(100, 23);
            this.ctxY.Text = "0";
            this.ctxZ.Name = "ctxZ";
            this.ctxZ.Size = new System.Drawing.Size(100, 23);
            this.ctxZ.Text = "0";
            this.ctxA.Name = "ctxA";
            this.ctxA.Size = new System.Drawing.Size(100, 23);
            this.ctxA.Items.AddRange(new object[] { "1", "2", "3" });
            this.ctxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxB.Name = "ctxB";
            this.ctxB.Size = new System.Drawing.Size(100, 23);
            this.ctxB.Items.AddRange(new object[] { "0,5", "1", "2" });
            this.ctxB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxCalculations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCompute});
            this.ctxCalculations.Name = "ctxCalculations";
            this.ctxCalculations.Size = new System.Drawing.Size(152, 22);
            this.ctxCalculations.Text = "Вычисления";
            this.ctxCompute.Name = "ctxCompute";
            this.ctxCompute.Size = new System.Drawing.Size(180, 22);
            this.ctxCompute.Text = "Вычислить";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная 14 (Вариант 28)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiColor;
        private System.Windows.Forms.ToolStripComboBox tscbColorPreset;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripTextBox tsbRed;
        private System.Windows.Forms.ToolStripTextBox tsbGreen;
        private System.Windows.Forms.ToolStripTextBox tsbBlue;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiParams;
        private System.Windows.Forms.ToolStripTextBox tsbX;
        private System.Windows.Forms.ToolStripTextBox tsbY;
        private System.Windows.Forms.ToolStripTextBox tsbZ;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripComboBox tscbA;
        private System.Windows.Forms.ToolStripComboBox tscbB;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculations;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompute;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslCoords;
        private System.Windows.Forms.ToolStripStatusLabel sslDateTime;
        private System.Windows.Forms.ToolStripDropDownButton tsddbExpression;
        private System.Windows.Forms.ToolStripStatusLabel sslMouseResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxColor;
        private System.Windows.Forms.ToolStripComboBox ctxColorCombo;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator1;
        private System.Windows.Forms.ToolStripTextBox ctxRed;
        private System.Windows.Forms.ToolStripTextBox ctxGreen;
        private System.Windows.Forms.ToolStripTextBox ctxBlue;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.ToolStripMenuItem ctxParams;
        private System.Windows.Forms.ToolStripTextBox ctxX;
        private System.Windows.Forms.ToolStripTextBox ctxY;
        private System.Windows.Forms.ToolStripTextBox ctxZ;
        private System.Windows.Forms.ToolStripSeparator ctxSeparator3;
        private System.Windows.Forms.ToolStripComboBox ctxA;
        private System.Windows.Forms.ToolStripComboBox ctxB;
        private System.Windows.Forms.ToolStripMenuItem ctxCalculations;
        private System.Windows.Forms.ToolStripMenuItem ctxCompute;
    }
}