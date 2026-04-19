using System.Drawing;

namespace lb_13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmbW = new System.Windows.Forms.ComboBox();
            this.cmbT = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblZooCaption = new System.Windows.Forms.Label();
            this.txtZoo = new System.Windows.Forms.TextBox();
            this.rbEq1 = new System.Windows.Forms.RadioButton();
            this.rbEq2 = new System.Windows.Forms.RadioButton();
            this.grpEquation = new System.Windows.Forms.GroupBox();
            this.rbEq3 = new System.Windows.Forms.RadioButton();
            this.lblR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblR.Text = "r";
            this.lblR.Visible = false;
            this.txtR.Visible = false;
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.txtR);
            this.grpEquation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(72, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(72, 89);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(72, 124);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(15, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "N";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(250, 58);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(18, 13);
            this.lblW.TabIndex = 3;
            this.lblW.Text = "W";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(250, 89);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(14, 13);
            this.lblT.TabIndex = 4;
            this.lblT.Text = "T";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(107, 58);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 5;
            this.txtX.Text = "1";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(107, 89);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 6;
            this.txtY.Text = "2";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(107, 121);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 7;
            this.txtN.Text = "20";
            // 
            // cmbW
            // 
            this.cmbW.FormattingEnabled = true;
            this.cmbW.Items.AddRange(new object[] {
            "0,05",
            "0,1",
            "0,2"});
            this.cmbW.Location = new System.Drawing.Point(294, 58);
            this.cmbW.Name = "cmbW";
            this.cmbW.Size = new System.Drawing.Size(121, 21);
            this.cmbW.TabIndex = 8;
            this.cmbW.Text = "0,05";
            // 
            // cmbT
            // 
            this.cmbT.FormattingEnabled = true;
            this.cmbT.Items.AddRange(new object[] {
            "1",
            "2",
            "10"});
            this.cmbT.Location = new System.Drawing.Point(294, 89);
            this.cmbT.Name = "cmbT";
            this.cmbT.Size = new System.Drawing.Size(121, 21);
            this.cmbT.TabIndex = 9;
            this.cmbT.Text = "10";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(153, 393);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblZooCaption
            // 
            this.lblZooCaption.AutoSize = true;
            this.lblZooCaption.Location = new System.Drawing.Point(311, 393);
            this.lblZooCaption.Name = "lblZooCaption";
            this.lblZooCaption.Size = new System.Drawing.Size(26, 13);
            this.lblZooCaption.TabIndex = 11;
            this.lblZooCaption.Text = "Zoo";
            // 
            // txtZoo
            // 
            this.txtZoo.Location = new System.Drawing.Point(352, 393);
            this.txtZoo.Name = "txtZoo";
            this.txtZoo.ReadOnly = true;
            this.txtZoo.Size = new System.Drawing.Size(285, 20);
            this.txtZoo.TabIndex = 12;
            // 
            // rbEq1
            // 
            this.rbEq1.AutoSize = true;
            this.rbEq1.Location = new System.Drawing.Point(19, 28);
            this.rbEq1.Name = "rbEq1";
            this.rbEq1.Size = new System.Drawing.Size(90, 17);
            this.rbEq1.TabIndex = 13;
            this.rbEq1.TabStop = true;
            this.rbEq1.Text = "Уравнение 1";
            this.rbEq1.UseVisualStyleBackColor = true;
            // 
            // rbEq2
            // 
            this.rbEq2.AutoSize = true;
            this.rbEq2.Location = new System.Drawing.Point(19, 51);
            this.rbEq2.Name = "rbEq2";
            this.rbEq2.Size = new System.Drawing.Size(90, 17);
            this.rbEq2.TabIndex = 14;
            this.rbEq2.TabStop = true;
            this.rbEq2.Text = "Уравнение 2";
            this.rbEq2.UseVisualStyleBackColor = true;
            // 
            // grpEquation
            // 
            this.grpEquation.Controls.Add(this.rbEq3);
            this.grpEquation.Controls.Add(this.rbEq1);
            this.grpEquation.Controls.Add(this.rbEq2);
            this.grpEquation.Location = new System.Drawing.Point(484, 45);
            this.grpEquation.Name = "grpEquation";
            this.grpEquation.Size = new System.Drawing.Size(193, 111);
            this.grpEquation.TabIndex = 15;
            this.grpEquation.TabStop = false;
            this.grpEquation.Text = "Выбор уравнения";
            // 
            // rbEq3
            // 
            this.rbEq3.AutoSize = true;
            this.rbEq3.Location = new System.Drawing.Point(19, 74);
            this.rbEq3.Name = "rbEq3";
            this.rbEq3.Size = new System.Drawing.Size(162, 17);
            this.rbEq3.TabIndex = 15;
            this.rbEq3.TabStop = true;
            this.rbEq3.Text = "Уравнение 3 ( Вариант 18 )";
            this.rbEq3.UseVisualStyleBackColor = true;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(250, 124);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 16;
            this.lblR.Text = "R";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(294, 124);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 17;
            this.txtR.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.grpEquation);
            this.Controls.Add(this.txtZoo);
            this.Controls.Add(this.lblZooCaption);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbT);
            this.Controls.Add(this.cmbW);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 13";
            this.grpEquation.ResumeLayout(false);
            this.grpEquation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.ComboBox cmbW;
        private System.Windows.Forms.ComboBox cmbT;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblZooCaption;
        private System.Windows.Forms.TextBox txtZoo;
        private System.Windows.Forms.RadioButton rbEq1;
        private System.Windows.Forms.RadioButton rbEq2;
        private System.Windows.Forms.GroupBox grpEquation;
        private System.Windows.Forms.RadioButton rbEq3;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtR;
    }
}