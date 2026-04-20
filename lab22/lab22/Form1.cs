using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab22_Variant18
{
    public class Form1 : Form
    {
        // Делегат: принимает размер матрицы N и IProgress для мониторинга, возвращает Task<int[,]>
        public delegate Task<int[,]> MatrixSumDelegate(int n, IProgress<int> progress);
        private MatrixSumDelegate sumDelegate;

        public Form1()
        {
            SetupUI();

            // Инициализация делегата лямбда-выражением
            sumDelegate = async (n, progress) =>
            {
                Random rnd = new Random();
                int[,] A = new int[n, n];
                int[,] B = new int[n, n];
                int[,] result = new int[n, n];
                int total = n * n;
                int processed = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = rnd.Next(1, 10);
                        B[i, j] = rnd.Next(1, 10);
                        result[i, j] = A[i, j] + B[i, j];
                        processed++;
                        progress.Report((int)((double)processed / total * 100));
                        await Task.Delay(1); // для видимости прогресса (можно убрать)
                    }
                }
                return result;
            };
        }

        private void SetupUI()
        {
            this.Text = "Лабораторная 22 (Вариант 18) – Сумма двух матриц";
            this.ClientSize = new Size(500, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblN = new Label { Text = "Размер матрицы N x N:", Location = new Point(20, 20), AutoSize = true };
            NumericUpDown nudSize = new NumericUpDown
            {
                Name = "nudSize",
                Location = new Point(180, 17),
                Width = 80,
                Minimum = 1,
                Maximum = 100,
                Value = 10
            };

            Button btnStart = new Button
            {
                Name = "btnStart",
                Text = "Вычислить сумму",
                Location = new Point(180, 55),
                Width = 120,
                Height = 30
            };
            btnStart.Click += BtnStart_Click;

            ProgressBar progressBar = new ProgressBar
            {
                Name = "progressBar",
                Location = new Point(20, 105),
                Width = 440,
                Height = 25,
                Minimum = 0,
                Maximum = 100
            };

            Label lblStatus = new Label
            {
                Name = "lblStatus",
                Text = "Ожидание",
                Location = new Point(20, 140),
                AutoSize = true
            };

            Label lblResult = new Label
            {
                Name = "lblResult",
                Text = "",
                Location = new Point(20, 170),
                AutoSize = true,
                Font = new Font("Consolas", 10f, FontStyle.Bold),
                ForeColor = Color.DarkBlue
            };

            this.Controls.AddRange(new Control[] { lblN, nudSize, btnStart, progressBar, lblStatus, lblResult });
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            NumericUpDown nudSize = this.Controls["nudSize"] as NumericUpDown;
            Button btnStart = this.Controls["btnStart"] as Button;
            ProgressBar progressBar = this.Controls["progressBar"] as ProgressBar;
            Label lblStatus = this.Controls["lblStatus"] as Label;
            Label lblResult = this.Controls["lblResult"] as Label;

            int n = (int)nudSize.Value;
            btnStart.Enabled = false;
            progressBar.Value = 0;
            lblStatus.Text = "Генерация и сложение матриц...";
            lblResult.Text = "";

            var progress = new Progress<int>(percent =>
            {
                progressBar.Value = percent;
                lblStatus.Text = $"Выполнено: {percent}%";
            });

            try
            {
                int[,] sumMatrix = await sumDelegate.Invoke(n, progress);
                lblResult.Text = "Результат (первые 5x5 элементов матрицы суммы):\n";
                int displaySize = Math.Min(5, n);
                for (int i = 0; i < displaySize; i++)
                {
                    for (int j = 0; j < displaySize; j++)
                        lblResult.Text += $"{sumMatrix[i, j],3} ";
                    lblResult.Text += "\n";
                }
                lblStatus.Text = "Готово!";
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Ошибка: {ex.Message}";
                lblStatus.Text = "Ошибка";
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }
    }
}